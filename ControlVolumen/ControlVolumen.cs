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
        public enum NivelVolumen { 
            alto,
            medio,
            bajo
        }

        private NivelVolumen estadoVolumen;
        public ControlVolumen()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Point punto1 = new Point(0, 0);
            Point punto2 = new Point(0, this.Height);
            Point punto3 = new Point(this.Width, this.Height);
            Point[] triangulo = { punto2, punto1, punto3 };
            g.FillPolygon(Brushes.Gray, triangulo);
                
        }

        private void ControlVolumen_Layout(object sender, LayoutEventArgs e)
        {
            if (e.AffectedProperty == "Bounds") {
                this.Width = 2 * this.Height;
            }
        }
    }
}
