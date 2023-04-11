using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle.Entities.formas
{
    public class Quadrado : Forma
    {
        public int Largura { get; set; }
        public int Altura { get; set; }


        public override void CalcularArea(Graphics g, PictureBox picturebox = null)
        {
            using (var caneta = new Pen(Color.Blue, 8))
            {
                g.DrawRectangle(caneta, 145, 85, 150, 150);
            }
        }
    }
}
