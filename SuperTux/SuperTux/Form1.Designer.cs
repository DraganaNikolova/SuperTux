namespace SuperTux
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMovements = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLifes = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.timerWindow = new System.Windows.Forms.Timer(this.components);
            this.timerLife = new System.Windows.Forms.Timer(this.components);
            this.screen1 = new System.Windows.Forms.Panel();
            this.coin7 = new System.Windows.Forms.PictureBox();
            this.coin6 = new System.Windows.Forms.PictureBox();
            this.coin5 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.mainPlatform = new System.Windows.Forms.PictureBox();
            this.penguin = new System.Windows.Forms.PictureBox();
            this.timerCountLifes = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.screen1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penguin)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMovements
            // 
            this.timerMovements.Enabled = true;
            this.timerMovements.Interval = 1;
            this.timerMovements.Tick += new System.EventHandler(this.timerMovements_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblLifes);
            this.groupBox1.Controls.Add(this.lblCoins);
            this.groupBox1.Location = new System.Drawing.Point(255, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(33, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 24);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "TIME:";
            // 
            // lblLifes
            // 
            this.lblLifes.AutoSize = true;
            this.lblLifes.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifes.Location = new System.Drawing.Point(434, 29);
            this.lblLifes.Name = "lblLifes";
            this.lblLifes.Size = new System.Drawing.Size(100, 24);
            this.lblLifes.TabIndex = 9;
            this.lblLifes.Text = "LIFES:";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(249, 29);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(115, 24);
            this.lblCoins.TabIndex = 8;
            this.lblCoins.Text = "COINS: ";
            // 
            // timerWindow
            // 
            this.timerWindow.Interval = 1;
            this.timerWindow.Tick += new System.EventHandler(this.timerWindow_Tick);
            // 
            // timerLife
            // 
            this.timerLife.Tick += new System.EventHandler(this.timerLife_Tick);
            // 
            // screen1
            // 
            this.screen1.Controls.Add(this.coin7);
            this.screen1.Controls.Add(this.coin6);
            this.screen1.Controls.Add(this.coin5);
            this.screen1.Controls.Add(this.obstacle1);
            this.screen1.Controls.Add(this.coin4);
            this.screen1.Controls.Add(this.coin3);
            this.screen1.Controls.Add(this.coin2);
            this.screen1.Controls.Add(this.coin1);
            this.screen1.Controls.Add(this.block2);
            this.screen1.Controls.Add(this.block1);
            this.screen1.Controls.Add(this.mainPlatform);
            this.screen1.Controls.Add(this.penguin);
            this.screen1.Location = new System.Drawing.Point(1, 78);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(1117, 512);
            this.screen1.TabIndex = 1;
            // 
            // coin7
            // 
            this.coin7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin7.Location = new System.Drawing.Point(588, 57);
            this.coin7.Name = "coin7";
            this.coin7.Size = new System.Drawing.Size(41, 37);
            this.coin7.TabIndex = 16;
            this.coin7.TabStop = false;
            // 
            // coin6
            // 
            this.coin6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin6.Location = new System.Drawing.Point(588, 110);
            this.coin6.Name = "coin6";
            this.coin6.Size = new System.Drawing.Size(41, 37);
            this.coin6.TabIndex = 15;
            this.coin6.TabStop = false;
            // 
            // coin5
            // 
            this.coin5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin5.Location = new System.Drawing.Point(588, 163);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(41, 37);
            this.coin5.TabIndex = 14;
            this.coin5.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.Image = ((System.Drawing.Image)(resources.GetObject("obstacle1.Image")));
            this.obstacle1.Location = new System.Drawing.Point(547, 362);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(116, 77);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle1.TabIndex = 12;
            this.obstacle1.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin4.Location = new System.Drawing.Point(781, 262);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(41, 37);
            this.coin4.TabIndex = 7;
            this.coin4.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin3.Location = new System.Drawing.Point(721, 262);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(41, 37);
            this.coin3.TabIndex = 6;
            this.coin3.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin2.Location = new System.Drawing.Point(446, 262);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(41, 37);
            this.coin2.TabIndex = 5;
            this.coin2.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin1.Location = new System.Drawing.Point(382, 262);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(41, 37);
            this.coin1.TabIndex = 4;
            this.coin1.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.block2.Location = new System.Drawing.Point(669, 328);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(206, 42);
            this.block2.TabIndex = 3;
            this.block2.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.block1.Location = new System.Drawing.Point(335, 328);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(206, 42);
            this.block1.TabIndex = 2;
            this.block1.TabStop = false;
            // 
            // mainPlatform
            // 
            this.mainPlatform.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPlatform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPlatform.Image = ((System.Drawing.Image)(resources.GetObject("mainPlatform.Image")));
            this.mainPlatform.Location = new System.Drawing.Point(-2, 440);
            this.mainPlatform.Name = "mainPlatform";
            this.mainPlatform.Size = new System.Drawing.Size(1119, 72);
            this.mainPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPlatform.TabIndex = 1;
            this.mainPlatform.TabStop = false;
            // 
            // penguin
            // 
            this.penguin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.penguin.Location = new System.Drawing.Point(13, 201);
            this.penguin.Name = "penguin";
            this.penguin.Size = new System.Drawing.Size(56, 81);
            this.penguin.TabIndex = 0;
            this.penguin.TabStop = false;
            // 
            // timerCountLifes
            // 
            this.timerCountLifes.Tick += new System.EventHandler(this.timerCountLifes_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 590);
            this.Controls.Add(this.screen1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperTux";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.screen1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penguin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMovements;
        private System.Windows.Forms.Timer timerWindow;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLifes;
        private System.Windows.Forms.Timer timerLife;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel screen1;
        private System.Windows.Forms.PictureBox coin7;
        private System.Windows.Forms.PictureBox coin6;
        private System.Windows.Forms.PictureBox coin5;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox mainPlatform;
        private System.Windows.Forms.PictureBox penguin;
        private System.Windows.Forms.Timer timerCountLifes;
    }
}

