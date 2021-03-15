using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public class Files
    {
        Form1 form1;
        RichTextBox textBox;
        private string fileName;
        private bool isFileSaved;
        private  string fileLocation;


        public string FileName { get => fileName; set => fileName = value; }
        public bool IsFileSaved { get => isFileSaved; set => isFileSaved = value; }
        public string FileLocation { get => fileLocation; set => fileLocation = value; }


        public void newFile()
        {
            this.FileName = "Bez tytułu.txt";
            this.IsFileSaved = true;


            if (IsFileSaved)
            {
                textBox.Text = "";
                form1.UpdateView();
            }
            else
            {
                DialogResult result = MessageBox.Show("Czy chcesz zapisać zmiany w " + FileName, "Notatnik", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (FileName.Contains("Bez tytułu.txt"))
                    {
                        SaveFileDialog newFileSave = new SaveFileDialog();
                        newFileSave.Filter = "Plik tekstowy|*txt";
                        if (newFileSave.ShowDialog() == DialogResult.OK)
                        {
                            SaveFile(newFileSave.FileName, textBox.Lines);
                            form1.UpdateView();
                        }
                        else
                        {
                            SaveFile(FileLocation, textBox.Lines);
                            form1.UpdateView();
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    textBox.Text = "";
                    form1.UpdateView();
                }

            }


        }
        public string OpenFile(string fileLocation)
        {

            string content;
            this.FileLocation = fileLocation;
            Stream stream = File.Open(fileLocation, FileMode.Open, FileAccess.ReadWrite);
            using (StreamReader streamReader = new StreamReader(stream))
            {
                content = streamReader.ReadToEnd();

            }
            UpdateFileStatus();
            return content;


        }

        private void UpdateFileStatus()
        {
            string filename = FileLocation.Substring(FileLocation.LastIndexOf("\\") + 1);
            this.FileName = filename;
            this.IsFileSaved = true;
        }

        public void SaveFile(string fileLocation, string[] lines)
        {
            this.FileLocation = fileLocation;
            Stream stream = File.Open(FileLocation, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter streamWriter = new StreamWriter(stream))
            {
                foreach(string line in lines)
                {
                    streamWriter.WriteLine(line);
                }
            }
            UpdateFileStatus();
        }
        public void newFileWithPassword()
        {
            
            
        }
        
        public void saveFileWithPassword()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Plik tekstowy (*.txt)|*.txt";
            dialog.ShowDialog();
            
        }
    }
}
