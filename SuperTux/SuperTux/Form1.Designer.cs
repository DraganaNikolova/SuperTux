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
            this.mainPlatform = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.coin12 = new System.Windows.Forms.PictureBox();
            this.coin11 = new System.Windows.Forms.PictureBox();
            this.obstacle3 = new System.Windows.Forms.PictureBox();
            this.block7 = new System.Windows.Forms.PictureBox();
            this.GOAL = new System.Windows.Forms.PictureBox();
            this.coin10 = new System.Windows.Forms.PictureBox();
            this.coin9 = new System.Windows.Forms.PictureBox();
            this.coin8 = new System.Windows.Forms.PictureBox();
            this.block6 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block5 = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.eater2 = new System.Windows.Forms.PictureBox();
            this.eater1 = new System.Windows.Forms.PictureBox();
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
            this.penguin = new System.Windows.Forms.PictureBox();
            this.timerCountLifes = new System.Windows.Forms.Timer(this.components);
            this.timerBalls = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.screen1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eater2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eater1)).BeginInit();
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
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblLifes);
            this.groupBox1.Controls.Add(this.lblCoins);
            this.groupBox1.Location = new System.Drawing.Point(338, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(621, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(33, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 24);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "TIME:";
            // 
            // lblLifes
            // 
            this.lblLifes.AutoSize = true;
            this.lblLifes.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifes.ForeColor = System.Drawing.Color.White;
            this.lblLifes.Location = new System.Drawing.Point(435, 30);
            this.lblLifes.Name = "lblLifes";
            this.lblLifes.Size = new System.Drawing.Size(100, 24);
            this.lblLifes.TabIndex = 9;
            this.lblLifes.Text = "LIFES:";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.White;
            this.lblCoins.Location = new System.Drawing.Point(249, 30);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(115, 24);
            this.lblCoins.TabIndex = 8;
            this.lblCoins.Text = "COINS: ";
            // 
            // timerWindow
            // 
            this.timerWindow.Interval = 1;
            // 
            // timerLife
            // 
            this.timerLife.Tick += new System.EventHandler(this.timerLife_Tick);
            // 
            // screen1
            // 
            this.screen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("screen1.BackgroundImage")));
            this.screen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screen1.Controls.Add(this.mainPlatform);
            this.screen1.Controls.Add(this.obstacle2);
            this.screen1.Controls.Add(this.obstacle1);
            this.screen1.Controls.Add(this.groupBox1);
            this.screen1.Controls.Add(this.block7);
            this.screen1.Controls.Add(this.block6);
            this.screen1.Controls.Add(this.block3);
            this.screen1.Controls.Add(this.block1);
            this.screen1.Controls.Add(this.block2);
            this.screen1.Controls.Add(this.block5);
            this.screen1.Controls.Add(this.block4);
            this.screen1.Controls.Add(this.coin12);
            this.screen1.Controls.Add(this.coin11);
            this.screen1.Controls.Add(this.obstacle3);
            this.screen1.Controls.Add(this.GOAL);
            this.screen1.Controls.Add(this.coin10);
            this.screen1.Controls.Add(this.coin9);
            this.screen1.Controls.Add(this.coin8);
            this.screen1.Controls.Add(this.eater2);
            this.screen1.Controls.Add(this.eater1);
            this.screen1.Controls.Add(this.coin7);
            this.screen1.Controls.Add(this.coin6);
            this.screen1.Controls.Add(this.coin5);
            this.screen1.Controls.Add(this.coin4);
            this.screen1.Controls.Add(this.coin3);
            this.screen1.Controls.Add(this.coin2);
            this.screen1.Controls.Add(this.coin1);
            this.screen1.Controls.Add(this.penguin);
            this.screen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen1.Location = new System.Drawing.Point(0, 0);
            this.screen1.Margin = new System.Windows.Forms.Padding(0);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(1263, 657);
            this.screen1.TabIndex = 1;
            this.screen1.Paint += new System.Windows.Forms.PaintEventHandler(this.screen1_Paint);
            // 
            // mainPlatform
            // 
            this.mainPlatform.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPlatform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPlatform.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPlatform.Image = ((System.Drawing.Image)(resources.GetObject("mainPlatform.Image")));
            this.mainPlatform.Location = new System.Drawing.Point(0, 585);
            this.mainPlatform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPlatform.Name = "mainPlatform";
            this.mainPlatform.Size = new System.Drawing.Size(1263, 72);
            this.mainPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPlatform.TabIndex = 1;
            this.mainPlatform.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.BackColor = System.Drawing.Color.Transparent;
            this.obstacle2.Image = ((System.Drawing.Image)(resources.GetObject("obstacle2.Image")));
            this.obstacle2.Location = new System.Drawing.Point(1037, 501);
            this.obstacle2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(116, 91);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 22;
            this.obstacle2.TabStop = false;
            // 
            // coin12
            // 
            this.coin12.BackColor = System.Drawing.Color.Transparent;
            this.coin12.Image = ((System.Drawing.Image)(resources.GetObject("coin12.Image")));
            this.coin12.Location = new System.Drawing.Point(777, 426);
            this.coin12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin12.Name = "coin12";
            this.coin12.Size = new System.Drawing.Size(41, 37);
            this.coin12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin12.TabIndex = 31;
            this.coin12.TabStop = false;
            // 
            // coin11
            // 
            this.coin11.BackColor = System.Drawing.Color.Transparent;
            this.coin11.Image = ((System.Drawing.Image)(resources.GetObject("coin11.Image")));
            this.coin11.Location = new System.Drawing.Point(717, 426);
            this.coin11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin11.Name = "coin11";
            this.coin11.Size = new System.Drawing.Size(41, 37);
            this.coin11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin11.TabIndex = 30;
            this.coin11.TabStop = false;
            // 
            // obstacle3
            // 
            this.obstacle3.BackColor = System.Drawing.Color.Transparent;
            this.obstacle3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.obstacle3.Image = ((System.Drawing.Image)(resources.GetObject("obstacle3.Image")));
            this.obstacle3.Location = new System.Drawing.Point(968, 512);
            this.obstacle3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obstacle3.Name = "obstacle3";
            this.obstacle3.Size = new System.Drawing.Size(249, 80);
            this.obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle3.TabIndex = 29;
            this.obstacle3.TabStop = false;
            // 
            // block7
            // 
            this.block7.BackColor = System.Drawing.Color.Transparent;
            this.block7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block7.BackgroundImage")));
            this.block7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.block7.Location = new System.Drawing.Point(1147, 354);
            this.block7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(116, 42);
            this.block7.TabIndex = 28;
            this.block7.TabStop = false;
            // 
            // GOAL
            // 
            this.GOAL.BackColor = System.Drawing.Color.Transparent;
            this.GOAL.Image = ((System.Drawing.Image)(resources.GetObject("GOAL.Image")));
            this.GOAL.Location = new System.Drawing.Point(1166, 242);
            this.GOAL.Name = "GOAL";
            this.GOAL.Size = new System.Drawing.Size(97, 118);
            this.GOAL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GOAL.TabIndex = 27;
            this.GOAL.TabStop = false;
            // 
            // coin10
            // 
            this.coin10.BackColor = System.Drawing.Color.Transparent;
            this.coin10.Image = ((System.Drawing.Image)(resources.GetObject("coin10.Image")));
            this.coin10.Location = new System.Drawing.Point(968, 200);
            this.coin10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin10.Name = "coin10";
            this.coin10.Size = new System.Drawing.Size(41, 37);
            this.coin10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin10.TabIndex = 26;
            this.coin10.TabStop = false;
            // 
            // coin9
            // 
            this.coin9.BackColor = System.Drawing.Color.Transparent;
            this.coin9.Image = ((System.Drawing.Image)(resources.GetObject("coin9.Image")));
            this.coin9.Location = new System.Drawing.Point(967, 253);
            this.coin9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin9.Name = "coin9";
            this.coin9.Size = new System.Drawing.Size(41, 37);
            this.coin9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin9.TabIndex = 25;
            this.coin9.TabStop = false;
            // 
            // coin8
            // 
            this.coin8.BackColor = System.Drawing.Color.Transparent;
            this.coin8.Image = ((System.Drawing.Image)(resources.GetObject("coin8.Image")));
            this.coin8.Location = new System.Drawing.Point(967, 305);
            this.coin8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin8.Name = "coin8";
            this.coin8.Size = new System.Drawing.Size(41, 37);
            this.coin8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin8.TabIndex = 24;
            this.coin8.TabStop = false;
            // 
            // block6
            // 
            this.block6.BackColor = System.Drawing.Color.Transparent;
            this.block6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block6.BackgroundImage")));
            this.block6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.block6.Location = new System.Drawing.Point(941, 354);
            this.block6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(97, 42);
            this.block6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block6.TabIndex = 23;
            this.block6.TabStop = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.Transparent;
            this.block3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block3.BackgroundImage")));
            this.block3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.block3.Location = new System.Drawing.Point(694, 485);
            this.block3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(183, 42);
            this.block3.TabIndex = 21;
            this.block3.TabStop = false;
            // 
            // block5
            // 
            this.block5.BackColor = System.Drawing.Color.Transparent;
            this.block5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block5.BackgroundImage")));
            this.block5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.block5.Location = new System.Drawing.Point(480, 274);
            this.block5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(355, 42);
            this.block5.TabIndex = 20;
            this.block5.TabStop = false;
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.Transparent;
            this.block4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block4.BackgroundImage")));
            this.block4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.block4.Location = new System.Drawing.Point(302, 354);
            this.block4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(78, 42);
            this.block4.TabIndex = 19;
            this.block4.TabStop = false;
            // 
            // eater2
            // 
            this.eater2.BackColor = System.Drawing.Color.Transparent;
            this.eater2.Image = ((System.Drawing.Image)(resources.GetObject("eater2.Image")));
            this.eater2.Location = new System.Drawing.Point(626, 220);
            this.eater2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eater2.Name = "eater2";
            this.eater2.Size = new System.Drawing.Size(50, 50);
            this.eater2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eater2.TabIndex = 18;
            this.eater2.TabStop = false;
            // 
            // eater1
            // 
            this.eater1.BackColor = System.Drawing.Color.Transparent;
            this.eater1.Image = ((System.Drawing.Image)(resources.GetObject("eater1.Image")));
            this.eater1.Location = new System.Drawing.Point(626, 512);
            this.eater1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eater1.Name = "eater1";
            this.eater1.Size = new System.Drawing.Size(50, 50);
            this.eater1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eater1.TabIndex = 17;
            this.eater1.TabStop = false;
            // 
            // coin7
            // 
            this.coin7.BackColor = System.Drawing.Color.Transparent;
            this.coin7.Image = ((System.Drawing.Image)(resources.GetObject("coin7.Image")));
            this.coin7.Location = new System.Drawing.Point(320, 200);
            this.coin7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin7.Name = "coin7";
            this.coin7.Size = new System.Drawing.Size(41, 37);
            this.coin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin7.TabIndex = 16;
            this.coin7.TabStop = false;
            // 
            // coin6
            // 
            this.coin6.BackColor = System.Drawing.Color.Transparent;
            this.coin6.Image = ((System.Drawing.Image)(resources.GetObject("coin6.Image")));
            this.coin6.Location = new System.Drawing.Point(319, 253);
            this.coin6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin6.Name = "coin6";
            this.coin6.Size = new System.Drawing.Size(41, 37);
            this.coin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin6.TabIndex = 15;
            this.coin6.TabStop = false;
            // 
            // coin5
            // 
            this.coin5.BackColor = System.Drawing.Color.Transparent;
            this.coin5.Image = ((System.Drawing.Image)(resources.GetObject("coin5.Image")));
            this.coin5.Location = new System.Drawing.Point(319, 305);
            this.coin5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(41, 37);
            this.coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin5.TabIndex = 14;
            this.coin5.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.BackColor = System.Drawing.Color.Transparent;
            this.obstacle1.Image = ((System.Drawing.Image)(resources.GetObject("obstacle1.Image")));
            this.obstacle1.Location = new System.Drawing.Point(302, 501);
            this.obstacle1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(113, 91);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle1.TabIndex = 12;
            this.obstacle1.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Transparent;
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(529, 426);
            this.coin4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(41, 37);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 7;
            this.coin4.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(469, 426);
            this.coin3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(41, 37);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 6;
            this.coin3.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(238, 426);
            this.coin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(41, 37);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 5;
            this.coin2.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(30, 426);
            this.coin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(41, 37);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 4;
            this.coin1.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Transparent;
            this.block2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block2.BackgroundImage")));
            this.block2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.block2.Location = new System.Drawing.Point(424, 485);
            this.block2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(189, 42);
            this.block2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block2.TabIndex = 3;
            this.block2.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Transparent;
            this.block1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block1.BackgroundImage")));
            this.block1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.block1.Location = new System.Drawing.Point(12, 485);
            this.block1.Margin = new System.Windows.Forms.Padding(0);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(284, 42);
            this.block1.TabIndex = 2;
            this.block1.TabStop = false;
            // 
            // penguin
            // 
            this.penguin.BackColor = System.Drawing.Color.Transparent;
            this.penguin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("penguin.BackgroundImage")));
            this.penguin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.penguin.Location = new System.Drawing.Point(12, 342);
            this.penguin.Margin = new System.Windows.Forms.Padding(0);
            this.penguin.Name = "penguin";
            this.penguin.Size = new System.Drawing.Size(78, 97);
            this.penguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.penguin.TabIndex = 0;
            this.penguin.TabStop = false;
            // 
            // timerCountLifes
            // 
            this.timerCountLifes.Tick += new System.EventHandler(this.timerCountLifes_Tick);
            // 
            // timerBalls
            // 
            this.timerBalls.Tick += new System.EventHandler(this.timerBalls_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 657);
            this.Controls.Add(this.screen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperTux";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.screen1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eater2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eater1)).EndInit();
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
        private System.Windows.Forms.PictureBox eater1;
        private System.Windows.Forms.PictureBox eater2;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox block5;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox block7;
        private System.Windows.Forms.PictureBox GOAL;
        private System.Windows.Forms.PictureBox coin10;
        private System.Windows.Forms.PictureBox coin9;
        private System.Windows.Forms.PictureBox coin8;
        private System.Windows.Forms.PictureBox block6;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle3;
        private System.Windows.Forms.Timer timerBalls;
        private System.Windows.Forms.PictureBox coin12;
        private System.Windows.Forms.PictureBox coin11;
    }
}

