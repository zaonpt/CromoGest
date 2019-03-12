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

        public DataGridViewCromoCell() : base() {  }

        public DataGridViewCromoCell(string s, int i) : base()
        {
            Value = s;
            NumCromos = i;
            switch (i)
            {
                case 0:
                    Style.BackColor = Color.LightSalmon;
                    Style.ForeColor = Color.Black;
                    break;
                case 1:
                    Style.BackColor = Color.LightGreen;
                    Style.ForeColor = Color.Black;
                    break;
                default:
                    Style.BackColor = Color.Green;
                    Style.ForeColor = Color.White;
                    break;
            }

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
            //base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            TextFormatFlags flagsCanto = TextFormatFlags.Bottom | TextFormatFlags.Right | TextFormatFlags.RightToLeft;
            TextFormatFlags flagsCentro = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            Font FontValue = new Font(cellStyle.Font.FontFamily, 9, cellStyle.Font.Style, GraphicsUnit.Pixel);
            Font FontNum = new Font(cellStyle.Font.FontFamily, 7, cellStyle.Font.Style, GraphicsUnit.Pixel);
            this.UseColumnTextForButtonValue = true;

            SolidBrush myBrush = new SolidBrush(Color.Gray);

            Pen p = new Pen(Color.Black, 1);

            //graphics.DrawRectangle(p, new Rectangle(cellBounds.X+1, cellBounds.Y+1, cellBounds.Width-2, cellBounds.Height-2));

            graphics.FillRectangle(myBrush, new Rectangle(cellBounds.X+1, cellBounds.Y+1, cellBounds.Width-2, cellBounds.Height-2));

            try
            {
                TextRenderer.DrawText(graphics, Value.ToString(), FontValue, new Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width, cellBounds.Height), Color.Black, flagsCentro);

                TextRenderer.DrawText(graphics, NumCromos.ToString(), FontNum, new Rectangle(cellBounds.X, cellBounds.Y-2, cellBounds.Width, cellBounds.Height), Color.Black, flagsCanto);
            }
            catch { }

        }
    }
}
