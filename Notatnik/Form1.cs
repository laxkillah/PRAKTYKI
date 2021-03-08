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
        string fileName = "";
        public byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public int BlockSize = 128;
        

        
        
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wszystkie pliki| *";
            dialog.Multiselect = false;
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                fileName = dialog.FileName;
                StreamReader f = new StreamReader(fileName); ;
                textBox.Text = f.ReadToEnd();
                f.Close();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fileName != "")
            {
                StreamWriter f = new StreamWriter(fileName);
                f.Write(textBox.Text);
                f.Close();
            }
            else saveAsToolStripMenuItem_Click(sender, e);

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Plik tekstowy (*.txt)|*.txt";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {

                fileName = dialog.FileName;
                StreamWriter streamWriter = new StreamWriter(fileName);
                streamWriter.Write(textBox.Text);
                streamWriter.Close();
            }

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