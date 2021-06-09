namespace DSED_05
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.pbRacer1 = new System.Windows.Forms.PictureBox();
            this.pbRacer4 = new System.Windows.Forms.PictureBox();
            this.pbRacer3 = new System.Windows.Forms.PictureBox();
            this.pbRacer2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.puntersRADBox = new System.Windows.Forms.GroupBox();
            this.btnJeremy = new System.Windows.Forms.RadioButton();
            this.btnVaughn = new System.Windows.Forms.RadioButton();
            this.btnJack = new System.Windows.Forms.RadioButton();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.cbxRacers = new System.Windows.Forms.ComboBox();
            this.lblJack = new System.Windows.Forms.Label();
            this.lblVaughn = new System.Windows.Forms.Label();
            this.lblJeremy = new System.Windows.Forms.Label();
            this.lbxEvents = new System.Windows.Forms.ListBox();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer2)).BeginInit();
            this.puntersRADBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbRaceTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRaceTrack.BackgroundImage")));
            this.pbRaceTrack.Location = new System.Drawing.Point(22, 21);
            this.pbRaceTrack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(1500, 532);
            this.pbRaceTrack.TabIndex = 0;
            this.pbRaceTrack.TabStop = false;
            // 
            // pbRacer1
            // 
            this.pbRacer1.Image = global::DSED05.Properties.Resources.bmw_logo;
            this.pbRacer1.Location = new System.Drawing.Point(22, 21);
            this.pbRacer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbRacer1.Name = "pbRacer1";
            this.pbRacer1.Size = new System.Drawing.Size(144, 133);
            this.pbRacer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRacer1.TabIndex = 1;
            this.pbRacer1.TabStop = false;
            // 
            // pbRacer4
            // 
            this.pbRacer4.Image = global::DSED05.Properties.Resources.porsche_logo;
            this.pbRacer4.Location = new System.Drawing.Point(22, 420);
            this.pbRacer4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbRacer4.Name = "pbRacer4";
            this.pbRacer4.Size = new System.Drawing.Size(144, 133);
            this.pbRacer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRacer4.TabIndex = 2;
            this.pbRacer4.TabStop = false;
            // 
            // pbRacer3
            // 
            this.pbRacer3.Image = global::DSED05.Properties.Resources.audi_logo;
            this.pbRacer3.Location = new System.Drawing.Point(22, 287);
            this.pbRacer3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbRacer3.Name = "pbRacer3";
            this.pbRacer3.Size = new System.Drawing.Size(144, 133);
            this.pbRacer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRacer3.TabIndex = 3;
            this.pbRacer3.TabStop = false;
            // 
            // pbRacer2
            // 
            this.pbRacer2.Image = global::DSED05.Properties.Resources.mercedes_logo;
            this.pbRacer2.Location = new System.Drawing.Point(22, 154);
            this.pbRacer2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbRacer2.Name = "pbRacer2";
            this.pbRacer2.Size = new System.Drawing.Size(144, 133);
            this.pbRacer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRacer2.TabIndex = 4;
            this.pbRacer2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Maroon;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(344, 734);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 60);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(582, 734);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(204, 60);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Next Round";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.BackColor = System.Drawing.Color.Maroon;
            this.btnPlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBet.ForeColor = System.Drawing.Color.White;
            this.btnPlaceBet.Location = new System.Drawing.Point(94, 734);
            this.btnPlaceBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(152, 60);
            this.btnPlaceBet.TabIndex = 7;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = false;
            this.btnPlaceBet.Click += new System.EventHandler(this.BtnPlaceBet_Click);
            // 
            // puntersRADBox
            // 
            this.puntersRADBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.puntersRADBox.Controls.Add(this.btnJeremy);
            this.puntersRADBox.Controls.Add(this.btnVaughn);
            this.puntersRADBox.Controls.Add(this.btnJack);
            this.puntersRADBox.Location = new System.Drawing.Point(86, 582);
            this.puntersRADBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.puntersRADBox.Name = "puntersRADBox";
            this.puntersRADBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.puntersRADBox.Size = new System.Drawing.Size(134, 123);
            this.puntersRADBox.TabIndex = 8;
            this.puntersRADBox.TabStop = false;
            // 
            // btnJeremy
            // 
            this.btnJeremy.AutoSize = true;
            this.btnJeremy.Location = new System.Drawing.Point(8, 76);
            this.btnJeremy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJeremy.Name = "btnJeremy";
            this.btnJeremy.Size = new System.Drawing.Size(75, 21);
            this.btnJeremy.TabIndex = 2;
            this.btnJeremy.TabStop = true;
            this.btnJeremy.Text = "Jeremy";
            this.btnJeremy.UseVisualStyleBackColor = true;
            this.btnJeremy.CheckedChanged += new System.EventHandler(this.PunterRad_Changed);
            // 
            // btnVaughn
            // 
            this.btnVaughn.AutoSize = true;
            this.btnVaughn.Location = new System.Drawing.Point(8, 48);
            this.btnVaughn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVaughn.Name = "btnVaughn";
            this.btnVaughn.Size = new System.Drawing.Size(78, 21);
            this.btnVaughn.TabIndex = 1;
            this.btnVaughn.TabStop = true;
            this.btnVaughn.Text = "Vaughn";
            this.btnVaughn.UseVisualStyleBackColor = true;
            this.btnVaughn.CheckedChanged += new System.EventHandler(this.PunterRad_Changed);
            // 
            // btnJack
            // 
            this.btnJack.AutoSize = true;
            this.btnJack.Location = new System.Drawing.Point(8, 20);
            this.btnJack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJack.Name = "btnJack";
            this.btnJack.Size = new System.Drawing.Size(58, 21);
            this.btnJack.TabIndex = 0;
            this.btnJack.TabStop = true;
            this.btnJack.Text = "Jack";
            this.btnJack.UseVisualStyleBackColor = true;
            this.btnJack.CheckedChanged += new System.EventHandler(this.PunterRad_Changed);
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(410, 596);
            this.betAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(160, 22);
            this.betAmount.TabIndex = 3;
            // 
            // cbxRacers
            // 
            this.cbxRacers.FormattingEnabled = true;
            this.cbxRacers.Location = new System.Drawing.Point(408, 627);
            this.cbxRacers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxRacers.Name = "cbxRacers";
            this.cbxRacers.Size = new System.Drawing.Size(160, 24);
            this.cbxRacers.TabIndex = 9;
            // 
            // lblJack
            // 
            this.lblJack.Location = new System.Drawing.Point(300, 602);
            this.lblJack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJack.Name = "lblJack";
            this.lblJack.Size = new System.Drawing.Size(100, 28);
            this.lblJack.TabIndex = 10;
            this.lblJack.Text = "label1";
            // 
            // lblVaughn
            // 
            this.lblVaughn.Location = new System.Drawing.Point(300, 631);
            this.lblVaughn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaughn.Name = "lblVaughn";
            this.lblVaughn.Size = new System.Drawing.Size(46, 16);
            this.lblVaughn.TabIndex = 11;
            this.lblVaughn.Text = "label2";
            // 
            // lblJeremy
            // 
            this.lblJeremy.AutoSize = true;
            this.lblJeremy.Location = new System.Drawing.Point(300, 659);
            this.lblJeremy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJeremy.Name = "lblJeremy";
            this.lblJeremy.Size = new System.Drawing.Size(46, 17);
            this.lblJeremy.TabIndex = 12;
            this.lblJeremy.Text = "label3";
            // 
            // lbxEvents
            // 
            this.lbxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbxEvents.FormattingEnabled = true;
            this.lbxEvents.ItemHeight = 16;
            this.lbxEvents.Location = new System.Drawing.Point(806, 608);
            this.lbxEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxEvents.Name = "lbxEvents";
            this.lbxEvents.Size = new System.Drawing.Size(642, 164);
            this.lbxEvents.TabIndex = 13;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(1090, 614);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 17);
            this.lblWinner.TabIndex = 14;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1782, 1055);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lbxEvents);
            this.Controls.Add(this.lblJeremy);
            this.Controls.Add(this.lblVaughn);
            this.Controls.Add(this.lblJack);
            this.Controls.Add(this.cbxRacers);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.puntersRADBox);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbRacer2);
            this.Controls.Add(this.pbRacer3);
            this.Controls.Add(this.pbRacer4);
            this.Controls.Add(this.pbRacer1);
            this.Controls.Add(this.pbRaceTrack);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer2)).EndInit();
            this.puntersRADBox.ResumeLayout(false);
            this.puntersRADBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.PictureBox pbRacer1;
        private System.Windows.Forms.PictureBox pbRacer4;
        private System.Windows.Forms.PictureBox pbRacer3;
        private System.Windows.Forms.PictureBox pbRacer2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.GroupBox puntersRADBox;
        private System.Windows.Forms.RadioButton btnJeremy;
        private System.Windows.Forms.RadioButton btnVaughn;
        private System.Windows.Forms.RadioButton btnJack;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.ComboBox cbxRacers;
        private System.Windows.Forms.Label lblJack;
        private System.Windows.Forms.Label lblVaughn;
        private System.Windows.Forms.Label lblJeremy;
        private System.Windows.Forms.ListBox lbxEvents;
        private System.Windows.Forms.Label lblWinner;
    }
}

