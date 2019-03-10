using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CromoGest.Controls
{
    public class DataGridViewCromoColumn : DataGridViewColumn
    {
        public DataGridViewCromoColumn()
        {
            this.CellTemplate = new DataGridViewCromoCell();
         
        }
    }
}
