using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using circle.Entities.formas;

namespace circle.operacoes
{
    public static class operacao
    {
        public static void clear(PictureBox boxPaint)
        {
            boxPaint.Invalidate();
            boxPaint.CreateGraphics().Clear(Color.White);
        }
    }
}
