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
    public partial class MenuForm : Form
    {
        private bool canExit { set; get; }
        private bool Do { set; get; }
        private Image image { set; get; }
        List<PictureBox> flakes { set; get; }

        public MenuForm()
        {
            InitializeComponent();
            canExit = true;
            Do = false;
            image = Resources.snowflake;
            flakes = new List<PictureBox>();
            flakes.Add(flake1);
            flakes.Add(flake2);
            flakes.Add(flake3);
            flakes.Add(flake4);
            flakes.Add(flake5);
            flakes.Add(flake6);
            flakes.Add(flake7);
            flakes.Add(flake8);
            timerFlake.Start();
            this.Cursor = CreateCursor((Bitmap)imageList1.Images[0], new Size(120, 100));
            this.DoubleBuffered = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            btnEasy.Visible = true;
            btnHard.Visible = true;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            canExit = false;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            canExit = false;
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(canExit)
                Application.Exit();
        }

        private static Cursor CreateCursor(Bitmap bm, Size size)
        {
            bm = new Bitmap(bm, size);
            bm.MakeTransparent();
            return new Cursor(bm.GetHicon());
        }

        private void timerFlake_Tick(object sender, EventArgs e)
        {
            Do = !Do;

            foreach(PictureBox f in flakes)
            {
                if (Do)
                {
                    f.BackgroundImage = image;
                }
                else
                {
                    f.BackgroundImage = null;
                }
            }
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            HowToPlay form = new HowToPlay();
            form.ShowDialog();
        }
    }
}
