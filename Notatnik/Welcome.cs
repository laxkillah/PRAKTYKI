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
        Form1 form1;
        public TextBox textBox = new TextBox();
        private string fileLocation;

        public string FileLocation { get => fileLocation; set => fileLocation = value; }

        public Welcome()
        {
            InitializeComponent();
            files = new Files();
            files.newFile();
            
        }
        public void textBox_TextChanged(object sender, EventArgs e)
        {
            files.IsFileSaved = false;
            form1.UpdateView();
        }

        private void newListPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Wprowadź hasło!", "Błędne hasło");
                return;
            }
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            files.newFile();


        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            files.newFile();
            textBox.Text = "";
        } 

        private void openListButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Otwórz plik";
            openFile.Filter = "Wszystkie pliki| *";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                textBox.TextChanged -= form1.textBox_TextChanged;
                textBox.Text = files.OpenFile(openFile.FileName);
                textBox.TextChanged += form1.textBox_TextChanged;
                form1.UpdateView();
            }
            
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
                //OpenFile(openFile.FileName);

            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "Wszystkie pliki| *";
            //openFile.Multiselect = false;
            //openFile.ShowDialog();
            //if (openFile.FileName != "")
            //{
            //    files.FileName = openFile.FileName;
            //    StreamReader f = new StreamReader(files.FileName);
            //    f.ReadToEnd();
            //    f.Close();
            //}

            //this.Hide();
            //Form1 f1 = new Form1();
            //files.OpenFile(openFile.FileName);
            //f1.openWelcome();
            //f1.ShowDialog();

        }
    }
}
