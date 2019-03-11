using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CromoGest.Controls
{
    public class DataGridViewCromoTextBoxCell : DataGridViewTextBoxCell
    {

        public int NumCromos
        {
            get => NumCromos; set
            {
                NumCromos = value;
                switch (value)
                {
                    case 0:
                        Style.BackColor = Color.LightSalmon;
                        break;
                    case 1:
                        Style.BackColor = Color.LightGreen;
                        break;
                    default:
                        Style.BackColor = Color.Green;
                        break;
                }
            }
        }

        public DataGridViewCromoTextBoxCell() : base()
        {
            Tag = "0";
            Style.BackColor = Color.LightSalmon;
        }

        public DataGridViewCromoTextBoxCell(string s) : base()
        {
            Value = s;
            if (int.TryParse(s, out int n))
            {
                NumCromos = n;
                Tag = "0";
                Style.BackColor = Color.LightSalmon;
            }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            TextFormatFlags flags = TextFormatFlags.Bottom | TextFormatFlags.Right | TextFormatFlags.RightToLeft;
            //Font Font2 = new Font(Style.Font.FontFamily, 9, Style.Font.Style, GraphicsUnit.Pixel);
            Font Font2 = new Font("Times New Roman", 7.0f);

            //ButtonRenderer.DrawButton(graphics, cellBounds, formattedValue.ToString(), Font2, true,
            //    System.Windows.Forms.VisualStyles.PushButtonState.Default);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            //TextRenderer.DrawText(graphics, Style.BackColor.ToString(), Font2,
            //    new Rectangle(0, 0, cellBounds.Width, cellBounds.Height), Color.Black, flags);
            graphics.DrawString(Tag.ToString(), Font2, myBrush,
                new Rectangle(cellBounds.X + 12, cellBounds.Y + 7, cellBounds.Width, cellBounds.Height));

        }
    }
}
