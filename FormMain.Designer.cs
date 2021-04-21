namespace High_Lowen
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgHighLeft = new System.Windows.Forms.PictureBox();
            this.imgHighMid = new System.Windows.Forms.PictureBox();
            this.imgHighRight = new System.Windows.Forms.PictureBox();
            this.imgLowRight = new System.Windows.Forms.PictureBox();
            this.imgLowLeft = new System.Windows.Forms.PictureBox();
            this.imgPlayerLeft = new System.Windows.Forms.PictureBox();
            this.imgPlayerRight = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.tmrWin = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgHighLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHighMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHighRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerRight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(88, 25);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(159, 61);
            this.lblHigh.TabIndex = 0;
            this.lblHigh.Text = "HIGH";
            this.lblHigh.Click += new System.EventHandler(this.lblHigh_Click);
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(515, 25);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(147, 61);
            this.lblLow.TabIndex = 1;
            this.lblLow.Text = "LOW";
            this.lblLow.Click += new System.EventHandler(this.lblLow_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(115, 200);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(564, 66);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "$5 to win $30? What a steal! First, choose whether to do HIGH or LOW first!\r\n";
            // 
            // imgHighLeft
            // 
            this.imgHighLeft.Location = new System.Drawing.Point(12, 89);
            this.imgHighLeft.Name = "imgHighLeft";
            this.imgHighLeft.Size = new System.Drawing.Size(115, 83);
            this.imgHighLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHighLeft.TabIndex = 3;
            this.imgHighLeft.TabStop = false;
            // 
            // imgHighMid
            // 
            this.imgHighMid.Location = new System.Drawing.Point(133, 89);
            this.imgHighMid.Name = "imgHighMid";
            this.imgHighMid.Size = new System.Drawing.Size(115, 83);
            this.imgHighMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHighMid.TabIndex = 4;
            this.imgHighMid.TabStop = false;
            // 
            // imgHighRight
            // 
            this.imgHighRight.Location = new System.Drawing.Point(254, 89);
            this.imgHighRight.Name = "imgHighRight";
            this.imgHighRight.Size = new System.Drawing.Size(115, 83);
            this.imgHighRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHighRight.TabIndex = 5;
            this.imgHighRight.TabStop = false;
            // 
            // imgLowRight
            // 
            this.imgLowRight.Location = new System.Drawing.Point(607, 89);
            this.imgLowRight.Name = "imgLowRight";
            this.imgLowRight.Size = new System.Drawing.Size(115, 83);
            this.imgLowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLowRight.TabIndex = 9;
            this.imgLowRight.TabStop = false;
            // 
            // imgLowLeft
            // 
            this.imgLowLeft.Location = new System.Drawing.Point(471, 89);
            this.imgLowLeft.Name = "imgLowLeft";
            this.imgLowLeft.Size = new System.Drawing.Size(115, 83);
            this.imgLowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLowLeft.TabIndex = 7;
            this.imgLowLeft.TabStop = false;
            // 
            // imgPlayerLeft
            // 
            this.imgPlayerLeft.Location = new System.Drawing.Point(89, 322);
            this.imgPlayerLeft.Name = "imgPlayerLeft";
            this.imgPlayerLeft.Size = new System.Drawing.Size(115, 83);
            this.imgPlayerLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerLeft.TabIndex = 11;
            this.imgPlayerLeft.TabStop = false;
            // 
            // imgPlayerRight
            // 
            this.imgPlayerRight.Location = new System.Drawing.Point(365, 322);
            this.imgPlayerRight.Name = "imgPlayerRight";
            this.imgPlayerRight.Size = new System.Drawing.Size(115, 83);
            this.imgPlayerRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerRight.TabIndex = 13;
            this.imgPlayerRight.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Enabled = false;
            this.btnRoll.Location = new System.Drawing.Point(210, 322);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(149, 83);
            this.btnRoll.TabIndex = 14;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(501, 322);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(124, 83);
            this.lblMoney.TabIndex = 15;
            this.lblMoney.Text = "Money $100";
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(673, 322);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(115, 47);
            this.btnPlay.TabIndex = 16;
            this.btnPlay.Text = "Play again";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(673, 391);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(115, 47);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Return to main menu";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(193, 425);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(38, 13);
            this.lblDealer.TabIndex = 18;
            this.lblDealer.Text = "Dealer";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(315, 424);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 19;
            this.lblPlayer.Text = "Player";
            // 
            // tmrWin
            // 
            this.tmrWin.Interval = 475;
            this.tmrWin.Tick += new System.EventHandler(this.tmrWin_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.imgPlayerRight);
            this.Controls.Add(this.imgPlayerLeft);
            this.Controls.Add(this.imgLowRight);
            this.Controls.Add(this.imgLowLeft);
            this.Controls.Add(this.imgHighRight);
            this.Controls.Add(this.imgHighMid);
            this.Controls.Add(this.imgHighLeft);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblHigh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "High Lowen";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHighLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHighMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHighRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox imgHighLeft;
        private System.Windows.Forms.PictureBox imgHighMid;
        private System.Windows.Forms.PictureBox imgHighRight;
        private System.Windows.Forms.PictureBox imgLowRight;
        private System.Windows.Forms.PictureBox imgLowLeft;
        private System.Windows.Forms.PictureBox imgPlayerLeft;
        private System.Windows.Forms.PictureBox imgPlayerRight;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Timer tmrWin;
    }
}

