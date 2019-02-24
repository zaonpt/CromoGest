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

        public CromoModelo(string numero, string descricao, int quantidade = 0)
        {
            Numero = numero;
            Descricao = descricao;
            Quantidade = quantidade;
        }

        public int Id { get; set; }

        public string Numero { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

    }
}
