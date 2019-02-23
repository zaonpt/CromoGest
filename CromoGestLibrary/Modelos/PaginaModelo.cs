using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class PaginaModelo
    {
        private string name;

        public PaginaModelo(string name)
        {
            this.name = name;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public List<CromoModelo> CromosNaPagina { get; set; } = new List<CromoModelo>();

    }
}
