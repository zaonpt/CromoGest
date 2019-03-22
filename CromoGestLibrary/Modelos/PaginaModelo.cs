using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class PaginaModelo /*: ICustomTypeDescriptor*/
    {
        //ATRIBUTOS
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public int IdCaderneta { get; set; }

        public List<CromoModelo> Cromos { get; set; } = new List<CromoModelo>();

        public PaginaModelo(string nome, int idCaderneta, int quantidade = 0)
        {
            Nome = nome;
            IdCaderneta = idCaderneta;
            Quantidade = quantidade;
        }

        public PaginaModelo()
        {
            Nome = "";
        }
    }
}
