using Newtonsoft.Json;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConverterJSON_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ConvertJSONtoXML()
        {
            string json = richTextBox1.Text;
            XNode node = JsonConvert.DeserializeXNode(json, "Root");
            richTextBox1.Text = node.ToString();
            MessageBox.Show("Dane przekonwertowane poprawnie!", "Sukces!");
        }
        public void ConvertXMLtoJSON()
        {
            string xml = richTextBox1.Text;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string json = JsonConvert.SerializeXmlNode(doc);
            richTextBox1.Text = json.ToString();
            MessageBox.Show("Dane przekonwertowane poprawnie!", "Sukces!");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Otwórz plik";
            openFileDialog1.Filter = "JSON(*.json)| *.json";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Name = openFileDialog1.FileName;
                richTextBox1.Clear();
                richTextBox1.Text = File.ReadAllText(Name);
                if (richTextBox1.Text == "")
                    MessageBox.Show("Plik nie zawiera danych do konwersji!", "Sprawdź plik!");
                else
                    ConvertJSONtoXML();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Otwórz plik";
            openFileDialog1.Filter = "XML(*.xml)| *.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Name = openFileDialog1.FileName;
                richTextBox1.Clear();
                richTextBox1.Text = File.ReadAllText(Name);
                if (richTextBox1.Text == "")
                    MessageBox.Show("Plik nie zawiera danych do konwersji!", "Sprawdź plik!");
                else
                    ConvertXMLtoJSON();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "")
                MessageBox.Show("Wprowadź dane do konwersji!", "Wprowadź dane!");
            else
                try
                {
                    ConvertJSONtoXML();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nieprawidłowy typ danych!");
                }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
                MessageBox.Show("Wprowadź dane do konwersji!", "Wprowadź dane!");
            else
                try
                {
                    ConvertXMLtoJSON();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nieprawidłowy typ danych!");
                }

        }
    }
}
