using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBrowser
{
    public partial class Form1 : Form
    {
        string currentDir = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Wybierz obraz";
            openFileDialog1.Filter = "Wszystkie pliki (*.*)|*.*";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var fb = new FolderBrowserDialog();
                if (fb.ShowDialog()==DialogResult.OK)
                {
                    currentDir = fb.SelectedPath;
                    var dirInfo = new DirectoryInfo(currentDir);
                    var files = dirInfo.GetFiles().Where(c=>c.Extension.Equals(".jpg") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".bmp") || c.Extension.Equals(".png"));
                    pictureBox1.Image = Image.FromFile(currentDir);
                }
            }
            catch
            {

            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private void previousButton_Click(object sender, EventArgs e)
        {

        }
    }
}
