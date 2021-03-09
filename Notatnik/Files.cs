using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public class Files : Form
    {
        string fileName = "";
        private TextBox textBox = new TextBox();
        public void newFile()
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
            

        }
        public void openFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wszystkie pliki| *";
            dialog.Multiselect = false;
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                fileName = dialog.FileName;
                StreamReader f = new StreamReader(fileName);
                f.Close();
            }
        }
        public void newFileWithPassword()
        {
            
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
        
        public void saveFileWithPassword()
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
    }
}
