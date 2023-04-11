namespace circle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnQuad = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnPent = new System.Windows.Forms.Button();
            this.btnRetang = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.boxPaint = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRIADOR DE ICONES TOP (OU NÃO)";
            // 
            // btnElipse
            // 
            this.btnElipse.Location = new System.Drawing.Point(52, 49);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(95, 31);
            this.btnElipse.TabIndex = 1;
            this.btnElipse.Text = "Elipse";
            this.btnElipse.UseVisualStyleBackColor = true;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnQuad
            // 
            this.btnQuad.Location = new System.Drawing.Point(153, 49);
            this.btnQuad.Name = "btnQuad";
            this.btnQuad.Size = new System.Drawing.Size(95, 31);
            this.btnQuad.TabIndex = 2;
            this.btnQuad.Text = "Quadrado";
            this.btnQuad.UseVisualStyleBackColor = true;
            this.btnQuad.Click += new System.EventHandler(this.btnQuad_Click);
            // 
            // btnTri
            // 
            this.btnTri.Location = new System.Drawing.Point(254, 49);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(95, 31);
            this.btnTri.TabIndex = 3;
            this.btnTri.Text = "Triangulo";
            this.btnTri.UseVisualStyleBackColor = true;
            this.btnTri.Click += new System.EventHandler(this.btnTri_Click);
            // 
            // btnOct
            // 
            this.btnOct.Location = new System.Drawing.Point(355, 49);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(95, 31);
            this.btnOct.TabIndex = 4;
            this.btnOct.Text = "Octágono";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnPent
            // 
            this.btnPent.Location = new System.Drawing.Point(456, 49);
            this.btnPent.Name = "btnPent";
            this.btnPent.Size = new System.Drawing.Size(95, 31);
            this.btnPent.TabIndex = 5;
            this.btnPent.Text = "Pentágono";
            this.btnPent.UseVisualStyleBackColor = true;
            this.btnPent.Click += new System.EventHandler(this.btnPent_Click);
            // 
            // btnRetang
            // 
            this.btnRetang.Location = new System.Drawing.Point(557, 49);
            this.btnRetang.Name = "btnRetang";
            this.btnRetang.Size = new System.Drawing.Size(95, 31);
            this.btnRetang.TabIndex = 6;
            this.btnRetang.Text = "Rêtangulo";
            this.btnRetang.UseVisualStyleBackColor = true;
            this.btnRetang.Click += new System.EventHandler(this.btnRetang_Click);
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(658, 49);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(95, 31);
            this.btnHex.TabIndex = 7;
            this.btnHex.Text = "Hexágono";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // boxPaint
            // 
            this.boxPaint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.boxPaint.Location = new System.Drawing.Point(165, 103);
            this.boxPaint.Name = "boxPaint";
            this.boxPaint.Size = new System.Drawing.Size(450, 320);
            this.boxPaint.TabIndex = 8;
            this.boxPaint.TabStop = false;
            this.boxPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.boxPaint_Paint);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(658, 364);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 31);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.boxPaint);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnRetang);
            this.Controls.Add(this.btnPent);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.btnQuad);
            this.Controls.Add(this.btnElipse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.boxPaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnElipse;
        private Button btnQuad;
        private Button btnTri;
        private Button btnOct;
        private Button btnPent;
        private Button btnRetang;
        private Button btnHex;
        private PictureBox boxPaint;
        private Button btnLimpar;
    }
}