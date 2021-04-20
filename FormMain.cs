using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_Lowen
{
    public partial class FormMain : Form
    {
        Random generator = new Random();
        bool choosePosition;
        bool diceHigh;
        bool diceLow;
        int roll;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            choosePosition = true;
        }
        public void dice_roll(PictureBox pictureBox)
        {
             roll = generator.Next(1, 7);
            if (roll == 1)
                pictureBox.Image = Properties.Resources.dice_six_faces_one;
            else if (roll == 2)
                pictureBox.Image = Properties.Resources.dice_six_faces_two;
            else if (roll == 3)
                pictureBox.Image = Properties.Resources.dice_six_faces_three;
            else if (roll == 4)
                pictureBox.Image = Properties.Resources.dice_six_faces_four;
            else if (roll == 5)
                pictureBox.Image = Properties.Resources.dice_six_faces_five;
            else if (roll == 6)
                pictureBox.Image = Properties.Resources.dice_six_faces_six;
        }
            

        private void lblHigh_Click(object sender, EventArgs e)
        {
            if (choosePosition)
            {
                lblInstructions.Text = "Roll higher than the dealer!";
                choosePosition = false;
                diceHigh = false;
                diceLow = true;
                btnRoll.Enabled = true;
                lblHigh.BackColor = Color.LightGreen;
                lblLow.BackColor = Color.LightCoral;
                dice_roll(imgHighLeft);
                dice_roll(imgHighRight);
            }
            else if (diceHigh == true)
            {
                lblInstructions.Text = "Roll higher than the dealer!";
                btnRoll.Enabled = true;
                lblHigh.BackColor = Color.LightGreen;
                lblLow.BackColor = Color.LightCoral;
                dice_roll(imgHighLeft);
                dice_roll(imgHighMid);
                dice_roll(imgHighRight);
            }
                
        }

        private void lblLow_Click(object sender, EventArgs e)
        {
            if (choosePosition)
            {
                lblInstructions.Text = "Roll lower than the dealer!";
                choosePosition = false;
                diceHigh = true;
                diceLow = false;
                btnRoll.Enabled = true;
                lblLow.BackColor = Color.LightGreen;
                lblHigh.BackColor = Color.LightCoral;
                dice_roll(imgLowLeft);
                dice_roll(imgLowRight);
            }
            else if (diceLow == true)
            {
                lblInstructions.Text = "Roll lower than the dealer!";
                btnRoll.Enabled = true;
                lblLow.BackColor = Color.LightGreen;
                lblHigh.BackColor = Color.LightCoral;
                dice_roll(imgLowMid);
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (choosePosition == false)
            {
                dice_roll(imgPlayerLeft);
                dice_roll(imgPlayerRight);
                
            }
        }
    }
}
