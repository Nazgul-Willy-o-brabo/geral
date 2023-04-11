using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle.Entities.formas
{
    public class Retangulo : Forma
    {
        public int Largura { get; set; }
        public int Altura { get; set; }


        public override void CalcularArea(Graphics g, PictureBox picturebox = null)
        {
            using(var caneta = new Pen(Color.Black,8))
            {
                g.DrawRectangle(caneta, 120, 110, 200, 100);
            }
        }
    }
}
