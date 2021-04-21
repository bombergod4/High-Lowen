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
        bool secondRound = false;
        bool labelInitialSwitch = true;
        int playerTotal;
        int dealerTotal;
        int roll;
        int money = 100;
        int red = 127;
        int green = 127;
        int blue = 129;
        System.IO.Stream str;
        System.Media.SoundPlayer snd;

        public FormMain()
        {
            InitializeComponent();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            choosePosition = true;
            lblMoney.Text = "Money $" + money;
            lblLow.Enabled = true;
            lblHigh.Enabled = true;
            str = Properties.Resources.Mirage_Voyage_Looping;
            snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
        }
        public int dice_roll(PictureBox pictureBox)
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
            return roll;

        }

        private void lblHigh_Click(object sender, EventArgs e)
        {
            if (choosePosition)
            {
                lblInstructions.Text = "Roll higher than the dealer!";
                choosePosition = false;
                lblHigh.Enabled = false;
                diceHigh = true;
                diceLow = false;
                btnRoll.Enabled = true;
                lblHigh.BackColor = Color.LightGreen;
                lblLow.BackColor = Color.LightCoral;
                dealerTotal += dice_roll(imgHighLeft);
                dealerTotal += dice_roll(imgHighRight);
            }
            else if (diceHigh == true && secondRound == true)
            {
                lblInstructions.Text = "Roll higher than the dealer!";
                btnRoll.Enabled = true;
                lblHigh.Enabled = false;
                diceHigh = true;
                lblHigh.BackColor = Color.LightGreen;
                lblLow.BackColor = Color.LightCoral;
                dealerTotal += dice_roll(imgHighLeft);
                dealerTotal += dice_roll(imgHighMid);
                dealerTotal += dice_roll(imgHighRight);
            }
                
        }

        private void lblLow_Click(object sender, EventArgs e)
        {
            if (choosePosition)
            {
                lblInstructions.Text = "Roll lower than the dealer!";
                choosePosition = false;
                lblLow.Enabled = false;
                diceHigh = false;
                diceLow = true;
                btnRoll.Enabled = true;
                lblLow.BackColor = Color.LightGreen;
                lblHigh.BackColor = Color.LightCoral;
                dealerTotal += dice_roll(imgLowLeft);
                dealerTotal += dice_roll(imgLowRight);
            }
            else if (diceLow == true && secondRound == true)
            {
                lblInstructions.Text = "Roll lower than the dealer!";
                lblLow.Enabled = false;
                btnRoll.Enabled = true;
                diceLow = true;
                lblLow.BackColor = Color.LightGreen;
                lblHigh.BackColor = Color.LightCoral;
                dealerTotal += dice_roll(imgLowRight);
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            playerTotal += dice_roll(imgPlayerLeft);
            playerTotal += dice_roll(imgPlayerRight);
            //if (diceLow == true)
            //    playerTotal = 0; /*ALWAYS WIN-CHEAT*/
            //else if (diceHigh == true)
            //    playerTotal = 19;
            lblPlayer.Text = "Player Roll : " + playerTotal;
            lblDealer.Text = "Dealer Roll : " + dealerTotal;
            if (diceHigh == true && secondRound == false)
            {
                if (playerTotal > dealerTotal)
                {
                    money += 4;
                    lblMoney.Text = "Money $" + money;
                    lblInstructions.Text = "Halfway there! Now, the hard part!";
                    secondRound = true;
                    btnRoll.Enabled = false;
                    diceHigh = false;
                    diceLow = true;
                }
                else
                {
                    lblInstructions.Text = "Better luck next time";
                    btnPlay.Enabled = true;
                    btnRoll.Enabled = false;
                }
            }
            else if (diceLow == true && secondRound == false)
            {
                if (playerTotal < dealerTotal)
                {
                    money += 4;
                    lblMoney.Text = "Money $" + money;
                    lblInstructions.Text = "Halfway there! Now, the hard part!";
                    secondRound = true;
                    btnRoll.Enabled = false;
                    diceHigh = true;
                    diceLow = false;
                }
                else
                {
                    lblInstructions.Text = "Better luck next time";
                    btnPlay.Enabled = true;
                    btnRoll.Enabled = false;
                }
            }
            else if (diceHigh == true && secondRound == true)
            {
                if (playerTotal > dealerTotal)
                {
                    money += 30;
                    lblMoney.Text = "Money $" + money;
                    lblInstructions.Text = "Fortune smiles upon you today!";
                    btnPlay.Enabled = true;
                    btnRoll.Enabled = false;
                    tmrWin.Enabled = true;
                    str = Properties.Resources.Mirage_Voyage_Climax;
                    snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                }
                else
                {
                    lblInstructions.Text = "Better luck next time";
                    btnPlay.Enabled = true;
                    btnRoll.Enabled = false;
                }
            }
            else if (diceLow == true && secondRound == true)
            {
                if (playerTotal < dealerTotal)
                {
                    money += 30;
                    lblMoney.Text = "Money $" + money;
                    lblInstructions.Text = "Fortune smiles upon you today!";
                    btnPlay.Enabled = true;
                    btnRoll.Enabled = false;
                    tmrWin.Enabled = true;
                    str = Properties.Resources.Mirage_Voyage_Climax;
                    snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                }
                else
                {
                    lblInstructions.Text = "Better luck next time";
                    btnPlay.Enabled = true;
                    btnRoll.Enabled = false;
                }
            }
            dealerTotal = 0;
            playerTotal = 0;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (money >= 5)
            {
                if (tmrWin.Enabled == true)
                {
                    snd.Stop();
                    str = Properties.Resources.Mirage_Voyage_Looping;
                    snd = new System.Media.SoundPlayer(str);
                    snd.PlayLooping();
                }
                playerTotal = 0;
                dealerTotal = 0;
                choosePosition = true;
                diceHigh = false;
                diceLow = false;
                secondRound = false;
                btnRoll.Enabled = false;
                btnPlay.Enabled = false;
                tmrWin.Enabled = false;
                lblHigh.Enabled = true;
                lblLow.Enabled = true;
                labelInitialSwitch = true;
                lblHigh.BackColor = default;
                lblLow.BackColor = default;
                imgHighLeft.Image = null;
                imgHighMid.Image = null;
                imgHighRight.Image = null;
                imgLowLeft.Image = null;
                imgLowRight.Image = null;
                imgPlayerLeft.Image = null;
                imgPlayerRight.Image = null;
                lblInstructions.ForeColor = default;
                lblMoney.ForeColor = default;
                this.BackColor = Color.FromArgb(128, 128, 255);
                money -= 5;
                lblMoney.Text = "Money $" + money;
                lblInstructions.Text = "$5 to win $30? What a steal! First, choose whether to do HIGH or LOW first";
            }
            else
                lblInstructions.Text = "Come back when you're a little... richer.";

        }

        private void tmrWin_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
                this.BackColor = Color.HotPink;
            else if (this.BackColor == Color.HotPink)
                this.BackColor = Color.Purple;
            else if (this.BackColor == Color.Purple)
                this.BackColor = Color.Aqua;
            else if (this.BackColor == Color.Aqua)
                this.BackColor = Color.LightGreen;
            else if (this.BackColor == Color.LightGreen)
                this.BackColor = Color.OrangeRed;
            else if (this.BackColor == Color.OrangeRed)
                this.BackColor = Color.DarkRed;
            else
                this.BackColor = Color.White;
            if (labelInitialSwitch == true)
            {
                lblInstructions.ForeColor = Color.FromArgb(red, green, blue);
                lblMoney.ForeColor = Color.Gold;
                labelInitialSwitch = false;
            }
            else if (lblInstructions.ForeColor != Color.FromArgb(1, 1, 255))
            {
                red -= 1;
                green -= 1;
                blue += 1;
                lblInstructions.ForeColor = Color.FromArgb(red, green, blue);
            }
            else
                labelInitialSwitch = true;
                
                
                

       
        }
    }
}
