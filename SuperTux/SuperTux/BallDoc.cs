using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTux
{
    public class BallsDoc
    {
        public List<Ball> Balls { get; set; }

        public BallsDoc()
        {
            Balls = new List<Ball>();
        }

        public void AddBall(Point center)
        {
            Ball b = new Ball();
            b.Center = center;
            
            Balls.Add(b);
        }

        public void Move(int width)
        {
            foreach (Ball b in Balls)
            {
                b.Move();
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }
    }
}
