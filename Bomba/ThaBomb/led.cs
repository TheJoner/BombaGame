using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ThaBomb { 
    public class led : Control
    {
        private bool _isOn = false;
        private Color _color = Color.Red;

        public led()
        {
            DoubleBuffered = true;
            Size = new Size(20, 20);
        }

        public bool IsOn
        {
            get { return _isOn; }
            set { _isOn = value; Invalidate(); }
        }

        public Color ledColor
        {
            get { return _color; }
            set { _color = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(_color);

            if (_isOn)
            {
                g.FillRectangle(brush, ClientRectangle);
            }
            else
            {
                g.DrawRectangle(Pens.Black, ClientRectangle);
            }
        }
    }

}


