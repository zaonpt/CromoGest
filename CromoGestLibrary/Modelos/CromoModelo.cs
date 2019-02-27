using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class CromoModelo
    {
        public CromoModelo()
        {
        }

        public CromoModelo(string numero, string descricao, int idPagina, int quantidade = 0)
        {
            Numero = numero;
            Descricao = descricao;
            Quantidade = quantidade;
            IdPagina = idPagina;
        }

        public int Id { get; set; }

        public string Numero { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int IdPagina { get; set; }

    }
}
