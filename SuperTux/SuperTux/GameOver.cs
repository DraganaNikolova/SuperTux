﻿using System;
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
    public partial class GameOver : Form
    {
        private bool canExit { set; get; }

        public GameOver()
        {
            InitializeComponent();
            this.Cursor = CreateCursor((Bitmap)imageList1.Images[0], new Size(120, 100));
            canExit = true;
            this.DoubleBuffered = true;
        }

        private static Cursor CreateCursor(Bitmap bm, Size size)
        {
            bm = new Bitmap(bm, size);
            bm.MakeTransparent();
            return new Cursor(bm.GetHicon());
        }

        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (canExit)
                Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            canExit = false;
            Application.Restart();
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
