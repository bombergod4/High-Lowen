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
        bool cardsLow;
        int roll;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           choosePosition = true;
        }

        private void lblHigh_Click(object sender, EventArgs e)
        {
            if (choosePosition)
            {
                choosePosition = false;
                diceHigh = true;
                cardsLow = true;
                roll = generator.Next(1, 7);
                if (roll == 1)
                    imgHighTopLeft.Image = Properties.Resources.dice_six_faces_one;
                else if (roll == 2)
                    imgHighTopLeft.Image = Properties.Resources.dice_six_faces_two;
                else if (roll == 3)
                    imgHighTopLeft.Image = Properties.Resources.dice_six_faces_three;
                else if (roll == 4)
                    imgHighTopLeft.Image = Properties.Resources.dice_six_faces_four;
                else if (roll == 5)
                    imgHighTopLeft.Image = Properties.Resources.dice_six_faces_five;
                else if (roll == 6)
                    imgHighTopLeft.Image = Properties.Resources.dice_six_faces_six;

            }
                
        }
    }
}
