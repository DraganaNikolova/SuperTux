using SuperTux.Properties;
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
        List<PictureBox> eaters { set; get; }
        private bool right;
        private bool left;
        bool jump;
        int G = 25;
        int Force;
        private int NumberCoins { set; get; }
        private int Lifes { set; get; }
        private int Seconds { set; get; }

        private BallsDoc ballsDoc;
        private int generateBall;
        private Random random;
        private Random random2;

        //promenlivi so koj se cuva izborot na igracot, za hard ili easy
        private bool Easy { set; get; }
        private bool Hard { set; get; }

        private MenuForm form { set; get; }
        private DialogResult result { set; get; }

        public Form1()
        {
            // na pocetokot se pojavuva menu strana kade otkako ke izbereme easy ili hard se vklucuva igrata spored soodvetna izbranata opcija
            form = new MenuForm();
            result = form.ShowDialog();
            this.Hide();

            int LocationMainX = form.Location.X;
            int locationMainy = form.Location.Y;
          
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Location = new Point(LocationMainX, locationMainy);
                Easy = true;
                Hard = false;
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                this.Location = new Point(LocationMainX, locationMainy);
                this.Focus();
                Hard = true;
                Easy = false;
            }
            else{ 
                Application.Exit();
            }
            //

            InitializeComponent();
            if (Easy == true)
                Lifes = 3;
            else if(Hard == true)
                Lifes = 1;
            lblLifes.Text = "LIFES: " + Lifes.ToString();
            NumberCoins = 0;

            blocks = new List<PictureBox>();
            coins = new List<PictureBox>();
            obstacles = new List<PictureBox>();
            eaters = new List<PictureBox>();

            blocks.Add(block1);
            blocks.Add(block2);
            blocks.Add(block3);
            blocks.Add(block4);
            blocks.Add(block5);
            blocks.Add(block6);
            blocks.Add(block7);

            coins.Add(coin1);
            coins.Add(coin2);
            coins.Add(coin3);
            coins.Add(coin4);
            coins.Add(coin5);
            coins.Add(coin6);
            coins.Add(coin7);
            coins.Add(coin8);
            coins.Add(coin9);
            coins.Add(coin10);
            coins.Add(coin11);
            coins.Add(coin12);

            obstacles.Add(obstacle1);
            obstacles.Add(obstacle2);
            obstacles.Add(obstacle3);

            eaters.Add(eater1);
            eaters.Add(eater2);

            ballsDoc = new BallsDoc();
            generateBall = 0;
            random = new Random();
            random2 = new Random();

            newGame();
            timerBalls.Start();

            this.DoubleBuffered = true;
        }

        private void newGame()
        {
            penguin.Location = new Point(94, 274);
            Invalidate();

            //timer koj odbrojuva 300 sekundi, koga ke pominat a ako pingvinot ne stignal do kukjata se gubi zhivot
            Seconds = 300;
            timerLife = new Timer();
            timerLife.Tick += new EventHandler(timerLife_Tick);
            timerLife.Interval = 500; // pola sekunda
            timerLife.Start();
            lblTime.Text = "TIME: " + Seconds.ToString();

            timerMovements.Interval = 1;
            timerCountLifes.Start();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                penguin.BackgroundImage = Resources.walk_0;
            }
                
            if (e.KeyCode == Keys.Left)
            { 
                left = true;
                penguin.BackgroundImage = Resources.walk_1;
            }
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
            //pingvinot stiga do kukjickata
            if(GOAL.Left <= penguin.Left + penguin.Width - 5)//GOAL.Right <= penguin.Right && penguin.Right <= GOAL.Right + GOAL.Width && GOAL.Bottom + GOAL.Height >= penguin.Bottom && GOAL.Bottom <= penguin.Bottom)
            {
                timerMovements.Stop();
                Win formp = new Win();
                DialogResult resultw = formp.ShowDialog();
                if (resultw == System.Windows.Forms.DialogResult.Yes)
                {
                }
                else
                {
                    Application.Exit();
                }
            }
            //

            //sobiranje na paricki
            for (int i = coins.Count - 1; i >= 0; i--)
            {
                PictureBox coin = coins[i];
                
                if (coin.Right <= penguin.Right && penguin.Right <= coin.Right + coin.Width && coin.Bottom + coin.Height >= penguin.Bottom && coin.Bottom <= penguin.Bottom)
                {
                    coins.Remove(coin);
                    screen1.Controls.Remove(coin);
                    NumberCoins++;
                    lblCoins.Text = "COINS: " + NumberCoins.ToString();
                    
                }
            }
            //

            //kolizija so prepreki
            foreach (PictureBox p in blocks)
            {
                //kolizija na desna ili leva strana od prepreka
                if(penguin.Right > p.Left && penguin.Left < (p.Right - penguin.Width ) && penguin.Bottom < p.Bottom && penguin.Bottom > p.Top && penguin.Top < p.Bottom)
                {
                    right = false;
                }
                if (penguin.Left < p.Right && penguin.Right > (p.Right - penguin.Width) && penguin.Bottom < p.Bottom && penguin.Bottom > p.Top && penguin.Top < p.Bottom)
                {
                    left = false;
                }
                //kolizija na gornata strana od preprekite
                if(penguin.Left + penguin.Width > p.Left && penguin.Left + penguin.Width  < p.Left + p.Width + penguin.Width && penguin.Top + penguin.Height >= p.Top && penguin.Top < p.Top)
                {
                    penguin.Top = p.Location.Y - penguin.Height - 10;
                    jump = false;
                    Force = 0;
                }
                //kolizija na dolnata strana od preprekite
                if (penguin.Left + penguin.Width > p.Left && penguin.Left + penguin.Width  < p.Left + p.Width + penguin.Width && penguin.Top - p.Bottom <= 10  && penguin.Top - p.Top >= 10)
                {
                    Force = -1;
                }
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
                if (penguin.Left + penguin.Width  > o.Left && penguin.Left + penguin.Width < o.Left + o.Width + penguin.Width && penguin.Top + penguin.Height >= o.Top && penguin.Top < o.Top)
                {

                    flag = true;
                }
                //kolizija na dolnata strana od preprekite
                if (penguin.Left + penguin.Width > o.Left && penguin.Left + penguin.Width < o.Left + o.Width + penguin.Width && penguin.Top - o.Bottom <= 10 && penguin.Top - o.Top >= 10)
                {
                    flag = true;
                }
                if (flag)
                {
                    Lifes -= 1;
                    timerLife.Stop();
                    Refresh();
                    newGame();
                }
            }
            //

            //kolizija so nekoja od preprekite koi go jadat
            for(int i=eaters.Count-1; i>=0; i--)
            {
                PictureBox o = eaters[i];
                bool flag = false;
                //kolizija na desna ili leva strana od prepreka
                if (penguin.Right > o.Left && penguin.Left < (o.Right - penguin.Width / 2) && penguin.Bottom > o.Top)
                {
                    flag = true;
                }
                else if (penguin.Left < o.Right && penguin.Right > (o.Right - penguin.Width / 2) && penguin.Bottom > o.Top)
                {
                    flag = true;
                }
                //kolizija na gornata strana od preprekite
                else if (penguin.Left + penguin.Width > o.Left && penguin.Left + penguin.Width < o.Left + o.Width + penguin.Width && penguin.Top + penguin.Height >= o.Top && penguin.Top < o.Top)
                {
                    Point NewLocation = o.Location;
                    eaters.Remove(o);
                    screen1.Controls.Remove(o);
                    Force = 0;
                    PictureBox coin = new PictureBox();
                    coin.Image = Resources.coin_0;
                    coin.SizeMode = PictureBoxSizeMode.StretchImage;
                    coin.Location = NewLocation;
                    coin.Width = 41;
                    coin.Height = 37;
                    
                    coin.BackColor = Color.Transparent;
                    
                    coins.Add(coin);
                    screen1.Controls.Add(coin);

                    penguin.Top -= 100;
                    penguin.Left += 50;
                    jump = true;
                }
                if (flag)
                {
                    Lifes -= 1;
                    timerLife.Stop();
                    Refresh();
                    newGame();
                }
            }
            //

            //dvizenje i skokanje na pingvinot
            if (right == true)
                penguin.Left += 3;
            if (left == true)
                penguin.Left -= 3;

            if (jump == true)
            {
                penguin.Top = penguin.Top - Force;
                Force -= 1;
            }

            if (penguin.Top + penguin.Height >= (screen1.Height - mainPlatform.Height))
            {
                penguin.Top = screen1.Height - penguin.Height - mainPlatform.Height;
                jump = false;
            }
            else
            {
                penguin.Top += 5;
            }
            //

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
                penguin.BackgroundImage = Resources.stand_0;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                penguin.BackgroundImage = Resources.stand_0;
            }
                
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
            
            int y2 = random2.Next(-5, 5);
            eater1.Top += y2;

            int y3 = random2.Next(-5, 5);
            eater2.Left += y3;


            lblTime.Text = "TIME: " + Seconds.ToString();
            lblLifes.Text = "LIFES: " + Lifes.ToString();
            
            Invalidate(true);

            if(Lifes == 0)
            {
                timerLife.Stop();
                GameOver formp = new GameOver();
                DialogResult resultp = formp.ShowDialog();
                if (resultp == System.Windows.Forms.DialogResult.Yes)
                {
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        
        private void timerCountLifes_Tick(object sender, EventArgs e)
        {
            lblLifes.Text = "LIFES: " + Lifes.ToString();
        }

        private void screen1_Paint(object sender, PaintEventArgs e)
        {
            ballsDoc.Draw(e.Graphics);
        }

        private void timerBalls_Tick(object sender, EventArgs e)
        {
            if (generateBall % 10 == 0)
            {
                int x = random.Next(2 * Ball.RADIUS, Height + (Ball.RADIUS * 2));
                int y = -Ball.RADIUS;
                ballsDoc.AddBall(new Point(x, y));
            }
            ++generateBall;
            ballsDoc.Move(Width);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
