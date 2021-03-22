using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Security.Cryptography;
using System.Threading;


namespace Notatnik
{
    

    public partial class Form1 : Form
    {
        Crypto crypto;
        Files files;
        string dir;
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
            files = new Files();
            files.newFile();
            this.Text = files.FileName;
            crypto = new Crypto();
            

        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@".. /..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        private DialogResult youWantSave()
        {
            DialogResult odp = MessageBox.Show("Chcesz zapisać zmiany?", "Notatnik",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (odp == DialogResult.Yes)
                saveToolStripMenuItem_Click(null, null);
            return odp;
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            if (textBox.Text != "") { DialogResult odp = youWantSave();
                if (odp == DialogResult.Cancel) e.Cancel = true; }

        }
        #region MenuItem
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files.IsFileSaved)
            {
                textBox.Text = "";
                files.newFile();
                UpdateView();
            }
            else
            {
                DialogResult result = MessageBox.Show("Czy chcesz zapisać zmiany w " + files.FileName, "Notatnik", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (files.FileName.Contains("Bez tytułu.txt"))
                    {
                        SaveFileDialog newFileSave = new SaveFileDialog();
                        newFileSave.Filter = "Nazwa pliku|*";
                        if (newFileSave.ShowDialog() == DialogResult.OK)
                        {
                            files.SaveFile(newFileSave.FileName, textBox.Lines);
                            UpdateView();
                        }
                        else
                        {
                            files.SaveFile(files.FileLocation, textBox.Lines);
                            UpdateView();
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    textBox.Text = "";
                    files.newFile();
                    UpdateView();
                }

            }
        }

        public void UpdateView()
        {
            this.Text = !files.IsFileSaved ? files.FileName + "*" : files.FileName;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Wprowadź hasło by zdeszyfrować");
            }
            else
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Otwórz plik";
                openFile.Filter = "Wszystkie pliki| *";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    textBox.TextChanged -= textBox_TextChanged;
                    textBox.Text = files.OpenFile(openFile.FileName);
                    textBox.TextChanged += textBox_TextChanged;
                    UpdateView();

                }
                crypto.Decrypt(textBox, passwordBox);
            }
            

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crypto.Encrypt(textBox, passwordBox);
            SaveFile();
            if (!files.IsFileSaved)
            {
                if(!this.Text.Contains("Bez tytułu.txt"))
                {
                    files.SaveFile(files.FileLocation, textBox.Lines);
                    UpdateView();
                }
                else
                {
                    SaveFileDialog fileSave = new SaveFileDialog();
                    fileSave.Filter = "Nazwa pliku|*";
                    if(fileSave.ShowDialog() == DialogResult.OK)
                    {
                        files.SaveFile(fileSave.FileName, textBox.Lines);
                        UpdateView();
                    }
                }
            }
            crypto.Decrypt(textBox, passwordBox);
        }

        private void SaveFile()
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.Filter = "Text(*.txt)|*.txt";
            if (fileSave.ShowDialog() == DialogResult.OK)
            {
                files.SaveFile(fileSave.FileName, textBox.Lines);
                UpdateView();
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crypto.Encrypt(textBox, passwordBox);
            SaveFile();
            crypto.Decrypt(textBox, passwordBox);

        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Redo();
        }
        #endregion
        #region ContextMenuItem
        private void undocnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void redocnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Redo();
        }

        private void cutcnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copycnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pastecnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }


        #endregion

        public void textBox_TextChanged(object sender, EventArgs e)
        {
            files.IsFileSaved = false;
            UpdateView();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            String TreeNodeName = treeView1.SelectedNode.ToString().Replace("TreeNode: ", String.Empty);
            System.Diagnostics.Process.Start(dir + "\\" + TreeNodeName);
            ListDirectory(treeView1, dir);
        }
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            return directoryNode;
        }
        private void ListDirectory(TreeView treeview1, string dir)
        {
            treeView1.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(dir);
            treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            crypto.Decrypt(textBox, passwordBox);
        }
    }
}