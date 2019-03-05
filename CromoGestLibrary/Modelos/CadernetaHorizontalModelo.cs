using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class CadernetaHorizontalModelo
    {
        public int Id { get; set; }

        public List<PaginaHorizontalModelo> PaginasHorizontais { get; set; } = new List<PaginaHorizontalModelo>();

    }
}
