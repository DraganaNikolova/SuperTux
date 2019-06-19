using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTux
{
    public class Ball
    {
        public static readonly int RADIUS = 8;

        public Point Center { get; set; }

        public Ball()
        {
            Random r = new Random();
        }

        public void Move()
        {
            Center = new Point(Center.X , Center.Y+10);
        }

        public void Draw(Graphics g)
        {
            Brush b = null;
            b = new SolidBrush(Color.LightSkyBlue);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);

            b.Dispose();

        }
    }
}
