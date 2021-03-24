using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_wyścigów
{
    public partial class Form1 : Form
    {
        public Greyhound[] GreyhoundArray = new Greyhound[4];
        public Guy[] GuyArray = new Guy[3];
        public Random MyRandomizer = new Random();
        public Form1()
        {
            InitializeComponent();
            CreateGreyhounds();
            CreateGuys();

        }
        public void CreateGuys()
        {
            GuyArray[0] = new Guy() { Name = "Janek", Cash = 50, MyRadioButton = janekRadioButton, MyLabel = janekBetLabel };
            GuyArray[0].UpdateLabels();
            GuyArray[1] = new Guy() { Name = "Bartek", Cash = 75, MyRadioButton = bartekRadioButton, MyLabel = bartekBetLabel };
            GuyArray[1].UpdateLabels();
            GuyArray[2] = new Guy() { Name = "Arek", Cash = 45, MyRadioButton = arekRadioButton, MyLabel = arekBetLabel };
            GuyArray[2].UpdateLabels();
        }
        public void CreateGreyhounds()
        {
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                MyRandom = MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RaceTrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                MyRandom = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RaceTrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                MyRandom = MyRandomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RaceTrackLength = racetrackPictureBox.Width - pictureBox4.Width,
                MyRandom = MyRandomizer
            };

        }

        private void janekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Janek";
        }

        private void bartekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bartek";
        }

        private void arekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Arek";
        }
        public bool properValuesInNumericUpDown(int BetAmount, int GreyhoundNumber)
        {
            if (BetAmount >= 5 && BetAmount <= 15 && GreyhoundNumber >= 1 && GreyhoundNumber <= 4)
            {
                return true;
            }

            else
            {
                MessageBox.Show("Podano nieprawidłową wartość", "Błędna wartość");
                return false;
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (janekRadioButton.Checked)
            {
                if (properValuesInNumericUpDown((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                {
                    GuyArray[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                }
            }
            else if (bartekRadioButton.Checked)
            {
                if (properValuesInNumericUpDown((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                {
                    GuyArray[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                }
            }
            else if (arekRadioButton.Checked)
            {
                if (properValuesInNumericUpDown((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                {
                    GuyArray[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Wygrał chart z numerem: " + (i + 1), "Koniec wyścigu");
                    for (int j = 0; j < 4; j++)
                    {
                        GreyhoundArray[j].TakeStartingPosition();
                    }
                    for (int k = 0; k < 3; k++)
                    {
                        GuyArray[k].Collect(i + 1);
                        GuyArray[k].ClearBet();
                        GuyArray[k].UpdateLabels();
                    }
                    groupBox1.Enabled = true;

                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }//
    }
}
