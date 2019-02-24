using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class PaginaModelo
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<CromoModelo> Cromos { get; set; } = new List<CromoModelo>();

        public PaginaModelo(string nome)
        {
            Nome = nome;
        }

        public PaginaModelo()
        {
        }
    }
}
