using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prosty_edytor_tekstów
{
    public partial class Form1 : Form
    {
        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();   
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Contains(".txt")) //Checks if it's all ok and if the file name contains .txt  
            {
                string open = File.ReadAllText(openFileDialog1.FileName);  
                richTextBox1.Text = open;  
            }
            else  
            {
                MessageBox.Show("The file you've chosen is not a text file");
            }
        }
    }
}
