using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle.Entities
{
    public abstract class Forma
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color color { get; set; }

        public Forma() { }
        protected Forma(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void CalcularArea(Graphics g, PictureBox picturebox = null);
    }
}
