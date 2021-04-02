﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drwale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            RedrawList();
        }
        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.FlapjackCount + " naleśników";
            }
        }
        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
            RedrawList();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Chrupkiego;
            else if (soggy.Checked == true)
                food = Flapjack.Wilgotnego;
            else if (browned.Checked == true)
                food = Flapjack.Rumianego;
            else
                food = Flapjack.Bananowego;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }
    }
}
