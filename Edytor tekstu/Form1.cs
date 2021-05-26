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
            openFileDialog1.Title = "Otwórz plik";
            openFileDialog1.Filter = "Pliki tekstowe(*.txt)| *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Name = openFileDialog1.FileName;
                richTextBox1.Clear();
                richTextBox1.Text = File.ReadAllText(Name, Encoding.UTF8);
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Zapisz plik";
            saveFileDialog1.Filter = "Pliki tekstowe(*.txt)| *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Name = saveFileDialog1.FileName;
                File.WriteAllText(Name, richTextBox1.Text, Encoding.UTF8);
            }
        }
    }
}
