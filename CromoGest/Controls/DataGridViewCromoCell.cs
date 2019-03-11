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

        //public int NumCromos
        //{
        //    get => NumCromos; set
        //    {
        //        NumCromos = value;
        //        switch (value)
        //        {
        //            case 0:
        //                Style.BackColor = Color.LightSalmon;
        //                break;
        //            case 1:
        //                Style.BackColor = Color.LightGreen;
        //                break;
        //            default:
        //                Style.BackColor = Color.Green;
        //                break;
        //        }
        //    }
        //}

        public DataGridViewCromoCell() : base()
        {
            //Tag = "0";
            //Style.BackColor = Color.LightSalmon;
        }

        //public DataGridViewCromoCell(string s) : base()
        //{
        //    Value = s;
        //    if (int.TryParse(s, out int n))
        //    {
        //        NumCromos = n;
        //        Tag = "0";
        //        Style.BackColor = Color.LightSalmon;
        //    }
        //}

        //public void IncCromo() { NumCromos++; }

        //public void DecCromo() { NumCromos= (NumCromos==0) ? 0 : NumCromos--; }

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
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            //TextFormatFlags flags = TextFormatFlags.Bottom | TextFormatFlags.Right | TextFormatFlags.RightToLeft;
            //Font Font2 = new Font(Style.Font.FontFamily, 9, Style.Font.Style, GraphicsUnit.Pixel);
            //ButtonRenderer.DrawButton(graphics, cellBounds, formattedValue.ToString(), Font2, true, System.Windows.Forms.VisualStyles.PushButtonState.Default);
            //TextRenderer.DrawText(graphics, Style.BackColor.ToString(), Font2, new Rectangle(0,0, cellBounds.Width, cellBounds.Height-2), Color.Black, flags);
        }
    }
}
