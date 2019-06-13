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

        public MenuForm()
        {
            InitializeComponent();
            canExit = true;
            this.Cursor = CreateCursor((Bitmap)imageList1.Images[0], new Size(120, 100));
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
    }
}
