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
    

    public partial class Form1 : Files
    {
        
        string fileName = "";
        public Form1()
        {
            InitializeComponent();
            
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
            if (textBox.Text != "")
            {
                DialogResult odp = youWantSave();
                if (odp == DialogResult.Cancel)
                    return;
                fileName = "";
                textBox.Clear();
            }
            newFile();
            listBox.Items.Add(fileName.Substring(fileName.LastIndexOf(@"\") + 1));
            

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                DialogResult odp = youWantSave();
                if (odp == DialogResult.Cancel)
                    return;
                fileName = "";
                textBox.Clear();
            }
            openFile();
            listBox.Items.Add(fileName.Substring(fileName.LastIndexOf(@"\") + 1));
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileWithPassword();
            listBox.Items.Add(fileName.Substring(fileName.LastIndexOf(@"\") + 1));
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName != "")
            {
                StreamWriter f = new StreamWriter(fileName);
                f.Write(textBox.Text);
                f.Close();
            }
            else saveAsToolStripMenuItem_Click(sender, e);
            listBox.Items.Add(fileName.Substring(fileName.LastIndexOf(@"\") + 1));
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

        
    }
}