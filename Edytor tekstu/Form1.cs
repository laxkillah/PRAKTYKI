using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edytor_tekstu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Otwórz plik";
            openFileDialog1.Filter = "Pliki tekstowe(*.txt)| *.txt";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename, Encoding.UTF8);
            richTextBox1.Text = readfile;
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Zapisz plik";
            saveFileDialog1.Filter = "Pliki tekstowe(*.txt)| *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }
    }
}
