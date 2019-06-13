using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTux
{
    public partial class Form1 : Form
    {
        List<PictureBox> blocks { set; get; }
        List<PictureBox> coins { set; get; }
        List<PictureBox> obstacles { set; get; }
        private bool right;
        private bool left;
        bool jump;
        int G = 25;
        int Force;
        private int NumberCoins { set; get; }
        private int Lifes { set; get; }
        private int Seconds { set; get; }
        public Form1()
        {
            InitializeComponent();
            Lifes = 3;
            lblLifes.Text = "LIFES: 3";
            NumberCoins = 0;
            blocks = new List<PictureBox>();
            coins = new List<PictureBox>();
            obstacles = new List<PictureBox>();

            blocks.Add(block1);
            blocks.Add(block2);
            
            coins.Add(coin1);
            coins.Add(coin2);
            coins.Add(coin3);
            coins.Add(coin4);

            obstacles.Add(obstacle1);
            newGame();

            this.DoubleBuffered = true;
        }

        private void newGame()
        {
            penguin.Location = new Point(94, 274);
            
            
            
            //timer koj odbrojuva 300 sekundi, koga ke pominat a ako pingvinot ne stignal do kukjata se gubi zhivot
            //Lifes = 3;
            Seconds = 300;
            timerLife = new Timer();
            timerLife.Tick += new EventHandler(timerLife_Tick);
            timerLife.Interval = 1000; // 1 sekunda
            timerLife.Start();
            lblTime.Text = "TIME: " + Seconds.ToString();

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Left)
                left = true;

            if(jump != true)
            {
                if(e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
                {
                    jump = true;
                    Force = G;
                }
            }
        }

        private void timerMovements_Tick(object sender, EventArgs e)
        {
            //sobiranje na paricki
            for(int i=coins.Count-1; i>=0; i--)
            {
                PictureBox coin = coins[i];
                if ( coin.Right <= penguin.Right && penguin.Right <= coin.Right + coin.Width)
                {
                    coins.Remove(coin);
                    screen.Controls.Remove(coin);
                    NumberCoins++;
                    lblCoins.Text = "COINS: " + NumberCoins.ToString();
                    
                }
            }
            //

            //kolizija so prepreki
            foreach (PictureBox p in blocks)
            {
                //kolizija na desna ili leva strana od prepreka
                if(penguin.Right > p.Left && penguin.Left < (p.Right - penguin.Width / 2) && penguin.Bottom > p.Top)
                {
                    right = false;
                }
                if (penguin.Left < p.Right && penguin.Right > (p.Right - penguin.Width / 2) && penguin.Bottom > p.Top)
                {
                    left = false;
                }
                //kolizija na gornata strana od preprekite
                if(penguin.Left + penguin.Width -1 > p.Left && penguin.Left + penguin.Width + 5 < p.Left + p.Width + penguin.Width && penguin.Top + penguin.Height >= p.Top && penguin.Top < p.Top)
                {
                    // penguin.Top = screen.Height -  mainPlatform.Height - p.Height - penguin.Height;
                    penguin.Top = screen.Height - mainPlatform.Height - p.Height - penguin.Height - (screen.Height - p.Top - p.Height - mainPlatform.Height) - 15;
                    Force = 0;
                    jump = false;
                }
            }
            //

            //dvizenje i skokanje na pingvinot
            if (right == true)
                penguin.Left += 3;
            if(left == true)
                penguin.Left -= 3;

            if(jump == true)
            {
                penguin.Top = penguin.Top - Force;
                Force -= 1;
            }

            if(penguin.Top + penguin.Height >= (screen.Height - mainPlatform.Height))
            {
                penguin.Top = screen.Height - penguin.Height - mainPlatform.Height;
                jump = false;
            }
            else
            {
                penguin.Top += 5;
            }
            //

            //kolizija so nekoja od preprekite koi go ubivaat
            foreach (PictureBox o in obstacles)
            {
                bool flag = false;
                //kolizija na desna ili leva strana od prepreka
                if (penguin.Right > o.Left && penguin.Left < (o.Right - penguin.Width / 2) && penguin.Bottom > o.Top)
                {
                    flag = true; 
                }
                if (penguin.Left < o.Right && penguin.Right > (o.Right - penguin.Width / 2) && penguin.Bottom > o.Top)
                {
                    flag = true;
                }
                //kolizija na gornata strana od preprekite
                if (penguin.Left + penguin.Width - 1 > o.Left && penguin.Left + penguin.Width + 5 < o.Left + o.Width + penguin.Width && penguin.Top + penguin.Height >= o.Top && penguin.Top < o.Top)
                {                   
                    flag = true;
                }
                if (flag)
                {
                    Lifes -= 1;
                    newGame();
                }
            }
            //
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Left)
                left = false;
        }
        
        private void timerLife_Tick(object sender, EventArgs e)
        {
            Seconds--;
            if(Seconds == 0)
            {
                Lifes -= 1;
                lblTime.Text = "TIME: " + Seconds.ToString();
                lblLifes.Text = "LIFES: " + Lifes.ToString();
                timerLife.Stop();
                newGame();
            }
            lblTime.Text = "TIME: " + Seconds.ToString();
            lblLifes.Text = "LIFES: " + Lifes.ToString();
        }
    }
}
