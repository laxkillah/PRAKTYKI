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

namespace Notatnik
{
    public partial class Welcome : Form
    {
        Files files;
        public ListBox listBox;
        public RichTextBox textBox;
        public Welcome()
        {
            InitializeComponent();
            files = new Files();
            files.newFile();

        }

        private void newListPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Wprowadź hasło!", "Błędne hasło");
                return; 
            }
            Form1 f1 = new Form1();
            f1.ShowDialog();
            files.newFile();
            listBox.Items.Add(files.FileName.Substring(files.FileName.LastIndexOf(@"\") + 1));

        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            f1.ShowDialog();
            files.newFile();
            listBox.Items.Add(files.FileName.Substring(files.FileName.LastIndexOf(@"\") + 1));
        }

        private void openListButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Otwórz plik";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Form1 f1 = new Form1();
                textBox.TextChanged -= textBox_TextChanged;
                textBox.Text = files.OpenFile(openFile.FileName);
                textBox.TextChanged += textBox_TextChanged;
                f1.UpdateView();
            }

            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "Wszystkie pliki| *";
            //openFile.Multiselect = false;
            //openFile.ShowDialog();
            //if (openFile.FileName != "")
            //{
            //    files.FileName = openFile.FileName;
            //    StreamReader f = new StreamReader(files.FileName);
            //    f.Close();
            //}
            //Form1 f1 = new Form1();
            //f1.ShowDialog();



        }
    }
}
