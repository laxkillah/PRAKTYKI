﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typy_zmiennych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                decimal myDecimalValue = 10;
                int myIntValue = (int)myDecimalValue;

                MessageBox.Show("myIntValue jest równe " + myIntValue);
            }
        }

        // RZUTOWANIE TYPÓW NA INNE - WYKAZ BŁĘDÓW

        private void button2_Click_1(object sender, EventArgs e)
        {
            //int myInt = 10;
            //byte myByte = (byte)myInt;
            //double myDouble = (double)myByte;
            //bool myBool = (bool)myDouble;
            //string myString = "false";
            //myBool = (bool)myString;
            //myString = (string)myInt;
            //myString = myInt.ToString();
            //myBool = (bool)myByte;
            //myByte = (byte)myBool;
            //short myShort = (short)myInt;
            //char myChar = 'x';
            //myString = (string)myChar;
            //long myLong = (long)myInt;
            //decimal myDecimal = (decimal)myLong;
            //myString = myString + myInt + myByte + myDouble + myChar;
        }
        public int MyMethod(bool yesNo)
        {
            if (yesNo)
            {
                return 45;
            }
            else
            {
                return 61;
            }
        }
    }
}
