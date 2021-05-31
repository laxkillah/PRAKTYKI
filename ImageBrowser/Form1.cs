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
        List<string> Imagefiles = new List<string>();
        int imageCount = 0;

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
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    findImagesInDirectory(fbd.SelectedPath);
                }
            }
        }
        private void findImagesInDirectory(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                if (s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".gif") || s.EndsWith(".bmp"))
                {
                    Imagefiles.Add(s);
                }
            }
            try
            {
                pictureBox1.ImageLocation = Imagefiles.First();
            }
            catch { MessageBox.Show("Nie znaleziono obrazu"); }

        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (imageCount + 1 == Imagefiles.Count)
            {
                MessageBox.Show("To ostatni obraz w tym katalogu!");
            }
            else
            {
                string nextImage = Imagefiles[imageCount + 1];
                pictureBox1.ImageLocation = nextImage;
                imageCount += 1;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (imageCount == 0)
            {
                MessageBox.Show("To pierwszy obraz w tym katalogu!");
            }
            else
            {
                string prevImage = Imagefiles[imageCount - 1];
                pictureBox1.ImageLocation = prevImage;
                imageCount -= 1;
            }
        }
    }
}
