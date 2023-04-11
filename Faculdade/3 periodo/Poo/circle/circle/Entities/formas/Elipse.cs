using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle.Entities.formas
{
    public class Elipse : Forma
    {
        public int Largura { get; set; }
        public int Altura { get; set; }


        public override void CalcularArea(Graphics g, PictureBox picturebox = null)
        {
            using (var caneta = new Pen(Color.Red, 8))
            {
                    g.DrawEllipse(caneta, 120, 60, 200, 200);
            }
        }
    }
}
