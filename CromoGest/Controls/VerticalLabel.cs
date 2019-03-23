using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CromoGest.Controls
{
    class VerticalLabel : Label
    {
        public int RotateAngle { get; set; }  // to rotate your text
        public string NewText { get; set; }   // to draw text
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Brush b = new SolidBrush(ForeColor);
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(RotateAngle);
            e.Graphics.DrawString(NewText, Font, b, 0f, 0f);
            base.OnPaint(e);
        }
    }
}
