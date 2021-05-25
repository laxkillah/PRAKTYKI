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
using System.Xml.Serialization;

namespace ConverterJSON_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Otwórz plik";
            openFileDialog1.Filter = "JSON(*.json)| *.json";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string json = File.ReadAllText(filename, Encoding.UTF8);
            XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json);
            richTextBox1.Text = json;
        }
        
            

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Otwórz plik";
            openFileDialog1.Filter = "XML(*.xml)| *.xml";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string xml = File.ReadAllText(filename, Encoding.UTF8);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string jsonText = JsonConvert.SerializeXmlNode(doc);
            richTextBox1.Text = xml;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void SerializeXmlNode()
        {
            string xml = richTextBox1.Text;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string jsonText = JsonConvert.SerializeXmlNode(doc);
        }
    }
}
