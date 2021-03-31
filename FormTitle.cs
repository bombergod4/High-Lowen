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
    public partial class FormTitle : Form
    {
        FormMain game;
        public FormTitle()
        {
            InitializeComponent();
        }

        private void tmrBackcolor_Tick(object sender, EventArgs e)
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
                
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tmrBackcolor.Enabled = false;
            game = new FormMain();
            game.ShowDialog();
            //this.Hide();
            //FormMan = new Form;
        }
    }
}
