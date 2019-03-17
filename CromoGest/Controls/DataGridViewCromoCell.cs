using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CromoGest.Controls
{
    public class DataGridViewCromoCell : DataGridViewButtonCell
    {
        public int NumCromos;

        public bool EmptyCell = false;

        public bool PaginaCell = false;

        public DataGridViewCromoCell() : base() { }

        public DataGridViewCromoCell(string s, int i) : base()
        {
            Value = s;
            NumCromos = i;
        }

        public void IncCromo() { NumCromos++; }

        public void DecCromo() { NumCromos = (NumCromos == 0) ? 0 : NumCromos--; }

        protected override void Paint(
            Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates elementState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {

            TextFormatFlags flagsCanto = TextFormatFlags.Bottom | TextFormatFlags.Right | TextFormatFlags.RightToLeft;
            TextFormatFlags flagsCentro = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            Font FontValue = new Font(cellStyle.Font.FontFamily, 9, cellStyle.Font.Style, GraphicsUnit.Pixel);
            Font FontNum = new Font(cellStyle.Font.FontFamily, 7, cellStyle.Font.Style, GraphicsUnit.Pixel);
            this.UseColumnTextForButtonValue = true;

            SetColors(out SolidBrush background, out Color corNumCromos, out Color corVal);

            if (PaginaCell)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                return;
            }

            if (EmptyCell)
            {

                graphics.FillRectangle(new SolidBrush(Color.FromArgb(171, 171, 171)), new Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width, cellBounds.Height));
                return;
            }

            Rectangle r = new Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width - 2, cellBounds.Height - 2);
            graphics.DrawRectangle(new Pen(Color.FromArgb(171, 171, 171)), new Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width - 1, cellBounds.Height - 1));
            graphics.FillRectangle(background, r);
            graphics.DrawRectangle(new Pen(Color.Black), r);

            TextRenderer.DrawText(graphics, Value.ToString(), FontValue, new Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width, cellBounds.Height), corVal, flagsCentro);
            if (NumCromos > 1)
                TextRenderer.DrawText(graphics, (NumCromos - 1).ToString(), FontNum, new Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width - 1, cellBounds.Height - 3), corNumCromos, flagsCanto);
        }

        private void SetColors(out SolidBrush background, out Color corNumCromos, out Color corVal)
        {
            switch (NumCromos)
            {
                case 0:
                    background = new SolidBrush(Color.Tomato);
                    corNumCromos = Color.Black;
                    corVal = Color.Black;
                    break;
                case 1:
                    background = new SolidBrush(Color.LightGreen);
                    corNumCromos = Color.Black;
                    corVal = Color.Black;
                    break;
                default:
                    background = new SolidBrush(Color.Green);
                    corNumCromos = Color.White;
                    corVal = Color.White;
                    break;
            }
        }
    }
}
