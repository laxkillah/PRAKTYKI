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
            

        }
        public string OpenFile(string fileLocation)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Wszystkie pliki| *";
            //dialog.Multiselect = false;
            //dialog.ShowDialog();
            //if (dialog.FileName != "")
            //{
            //    fileName = dialog.FileName;
            //    StreamReader f = new StreamReader(fileName);
            //    f.Close();
            //}
            string content;
            this.FileLocation = fileLocation;
            Stream stream = File.Open(fileLocation, FileMode.Open, FileAccess.ReadWrite);
            using(StreamReader streamReader=new StreamReader(stream))
            {
                content = streamReader.ReadToEnd();

            }
            string filename = FileLocation.Substring(FileLocation.LastIndexOf("\\") + 1);
            this.FileName = filename;
            this.IsFileSaved = true;
            return content;
            

        }
        public void SaveFile(string fileName, string[] lines)
        {

        }
        public void newFileWithPassword()
        {
            
            
        }
        
        public void saveFileWithPassword()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Plik tekstowy (*.txt)|*.txt";
            dialog.ShowDialog();
            //if (dialog.FileName != "")
            //{

            //    fileName = dialog.FileName;
            //    StreamWriter streamWriter = new StreamWriter(fileName);
            //    streamWriter.Write(this.textBox.Text);
            //    streamWriter.Close();
            //}
            

        }
    }
}
