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

namespace Notatnik
{
    
    public partial class Form1 : Form
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
        
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e) 
        {
            if (textBox.Text != "") { DialogResult odp = youWantSave();
                if (odp == DialogResult.Cancel) e.Cancel = true; } 
        
        }

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
                StreamReader f = new StreamReader(fileName);
                headerBox.Text = f.ReadToEnd();
                textBox.Text = f.ReadToEnd();
                f.Close();
            }
            textBox.Text = Decrypt(Decrypt(textBox.Text));;
            headerBox.Text = Decrypt(Decrypt(headerBox.Text));



        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = Encrypt(Encrypt(textBox.Text));
            headerBox.Text = Encrypt(Encrypt(headerBox.Text));
            if (fileName != "")
            {
                StreamWriter f = new StreamWriter(fileName);
                f.Write(textBox.Text, headerBox.Text);
                f.Close();
            }
            else saveAsToolStripMenuItem_Click(sender, e);
            textBox.Text = Decrypt(Decrypt(textBox.Text));
            headerBox.Text = Decrypt(Decrypt(headerBox.Text));
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = Encrypt(Encrypt(textBox.Text));
            headerBox.Text = Encrypt(Encrypt(headerBox.Text));
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Plik tekstowy (*.txt)|*.txt";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                
                fileName = dialog.FileName;
                StreamWriter f = new StreamWriter(fileName);
                f.Write(textBox.Text, headerBox);
                f.Close();
            }
            textBox.Text = Decrypt(Decrypt(textBox.Text));
            headerBox.Text = Decrypt(Decrypt(headerBox.Text));

        }

        #region Encrypt & Decrypt
        string Encrypt (string decrypted)
        {
            string hash = "test12345";
            byte[] data = UTF8Encoding.UTF8.GetBytes(decrypted);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();

            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }
        string Decrypt (string encrypted)
        {
            string hash = "test12345";
            byte[] data = Convert.FromBase64String(encrypted);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();

            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }
        #endregion

        #region MenuItem
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
