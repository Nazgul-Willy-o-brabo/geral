using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle.Entities.formas
{
    public class Triangulo : Forma
    {
        public override void CalcularArea(Graphics g, PictureBox paintBox)
        {
            int tamanho = 100;
            var pontos = new Point[3];
            var cx = paintBox.Width / 2;
            var cy = paintBox.Height / 2;
            double angulo = 2 * Math.PI / 3; //Angulo 120 graus cada vertice

            for(int i=0; i<3; i++)
            {
                int x = (int)(cx + tamanho * Math.Cos(i * angulo));
                int y = (int)(cy + tamanho * Math.Sin(i * angulo));
                pontos[i] = new Point(x, y);
            }
            using (var gradiente = new LinearGradientBrush(new Rectangle(cx - tamanho, cy - tamanho, tamanho * 2, tamanho * 2), Color.Red, Color.Blue, LinearGradientMode.Horizontal))
            {
                using (var caneta = new Pen(gradiente, 8))
                {
                    g.DrawPolygon(caneta, pontos);
                }
            }
        }
    }
}
