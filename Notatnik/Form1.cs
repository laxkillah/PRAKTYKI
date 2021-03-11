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
        string fileName = "";

        public Form1()
        {
            InitializeComponent();
            files = new Files();
            files.newFile();
            this.Text = files.FileLocation;
            crypto = new Crypto();
 
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
                DialogResult result = MessageBox.Show("Czy chcesz zapisać zmiany w " + files.FileName, "Notatnik",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if(files.FileName.Contains("Bez tytułu.txt"))
                    {
                        SaveFileDialog newFileSave = new SaveFileDialog();
                        newFileSave.Filter = "Plik tekstowy|*txt";
                        if (newFileSave.ShowDialog()==DialogResult.OK)
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
                else if(result == DialogResult.No)
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

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Otwórz plik";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                textBox.TextChanged -= textBox_TextChanged;
                textBox.Text = files.OpenFile(openFile.FileName);
                textBox.TextChanged += textBox_TextChanged;
                UpdateView();
            }
            crypto.Decrypt(textBox);
            listBox.Items.Add(files.FileName.Substring(files.FileName.LastIndexOf(@"\") + 1));


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(files.IsFileSaved)
            {
                if(!this.Text.Contains("Bez tytułu.txt"))
                {
                    files.SaveFile(files.FileLocation, textBox.Lines);
                    UpdateView();
                }
                else
                {
                    SaveFile();
                }
            }
            crypto.Encrypt(textBox);
            listBox.Items.Add(fileName.Substring(fileName.LastIndexOf(@"\") + 1));
            
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
            crypto.Encrypt(textBox);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            
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

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            files.IsFileSaved = false;
            UpdateView();
        }
    }
}