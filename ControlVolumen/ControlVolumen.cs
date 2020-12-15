using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVolumen
{
    public partial class ControlVolumen : UserControl
    {
        int valor;
        double radianes = (30 * Math.PI) / 180;
        double tangente30;
        int alturaPorValor;
        Color colorVolumen;
        Color fondo;
        Boolean arrastre;
        
       
        public ControlVolumen()
        {
            valor = 350;
            tangente30 = Math.Tan(radianes);
            alturaPorValor = Convert.ToInt32(valor * tangente30);
            fondo = Color.Gray;
            InitializeComponent();

        }

        public int nivelVolumen
        {
            get { return valor; }
            set { valor = value;
                Invalidate();
            }
        }

        public Color colorNivelVolumen
        {
            get { return colorVolumen; }
            set { colorVolumen = value; }
        }

        public Color colorFondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.DoubleBuffered = true;
            Graphics g = e.Graphics;
            Brush brushFondo = new SolidBrush(colorFondo);
            Brush brushVolumenBajo = new SolidBrush(colorNivelVolumen);
            Point punto1 = new Point(0, this.Height);
            Point punto2 = new Point(this.Width, this.Height);
            Point punto3 = new Point(this.Width, 0);
            Point[] triangulo = { punto1, punto2, punto3 };
            g.FillPolygon(brushFondo, triangulo);

            //Point punto2Volumen = new Point(valor, this.Height);
            //Point punto3Volumen = new Point(valor, 0);
            Point punto1Volumen = new Point(0, this.Height);
            Point punto2Volumen = new Point(valor, this.Height - alturaPorValor);
            Point punto3Volumen = new Point(valor, this.Height);
            
            Point[] trianguloVolumen = { punto1Volumen, punto2Volumen, punto3Volumen };
           
            g.FillPolygon(brushVolumenBajo, trianguloVolumen);
            
                
        }

        private void ControlVolumen_Layout(object sender, LayoutEventArgs e)
        {
            if (e.AffectedProperty == "Bounds") {
                this.Width = 2 * this.Height;
            }
        }

        private void ControlVolumen_MouseClick(object sender, MouseEventArgs e)
        {
            int puntoPulsacion = e.Location.X;
            nivelVolumen = puntoPulsacion;
            if (nivelVolumen > this.Width / 3 *2)
            {
                colorNivelVolumen = Color.Red;
            }
            else if (nivelVolumen <= this.Width / 3)
            {
                colorNivelVolumen = Color.Green;
            }
            else if(this.Width >= nivelVolumen || nivelVolumen > this.Width / 3)
            {
                colorNivelVolumen = Color.Yellow;
            }
            Invalidate();
        }

        private void ControlVolumen_MouseDown(object sender, MouseEventArgs e)
        {
            arrastre = true;
        }

        private void ControlVolumen_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastre) {
                int puntoPulsacion = e.Location.X;
                nivelVolumen = puntoPulsacion;
                if (nivelVolumen > this.Width / 3 * 2)
                {
                    colorNivelVolumen = Color.Red;
                }
                else if (nivelVolumen <= this.Width / 3)
                {
                    colorNivelVolumen = Color.Green;
                }
                else if (this.Width >= nivelVolumen || nivelVolumen > this.Width / 3)
                {
                    colorNivelVolumen = Color.Yellow;
                }
                Invalidate();
            }
        }

        private void ControlVolumen_MouseUp(object sender, MouseEventArgs e)
        {
            arrastre = false;
        }
    }
}
