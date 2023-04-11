using circle.Entities.formas;
using circle.operacoes;
using System.Linq.Expressions;

namespace circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boxPaint_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnRetang_Click(object sender, EventArgs e)
        {
            var retangulo = new Retangulo(); 
            retangulo.CalcularArea(boxPaint.CreateGraphics());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            operacao.clear(boxPaint);
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            var elipse = new Elipse();
            elipse.CalcularArea(boxPaint.CreateGraphics());
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            var quadrado = new Quadrado();
            quadrado.CalcularArea(boxPaint.CreateGraphics());
        }

        private void btnTri_Click(object sender, EventArgs e)
        {
            var triangulo = new Triangulo();
            triangulo.CalcularArea(boxPaint.CreateGraphics(),boxPaint);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            var octagon = new Octagono();
            octagon.CalcularArea(boxPaint.CreateGraphics(), boxPaint);
        }

        private void btnPent_Click(object sender, EventArgs e)
        {
            var pent = new Pentagono();
            pent.CalcularArea(boxPaint.CreateGraphics(), boxPaint);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            var hex = new Hexagono();
            hex.CalcularArea(boxPaint.CreateGraphics(), boxPaint);
        }
    }
}