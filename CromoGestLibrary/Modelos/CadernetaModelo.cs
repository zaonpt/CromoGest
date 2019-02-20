using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class CadernetaModelo
    {
        /// <summary>
        /// Identificador Automático
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da Caderneta
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Quantidade total de cromo que uma caderneta leva
        /// </summary>
        public int QuantidadeCromos { get; set; }

        /// <summary>
        /// Quantidade de cromos que uma seca traz
        /// </summary>
        public int QuantidadeCromosSaqueta { get; set; }

        /// <summary>
        /// Custo de uma carteira
        /// </summary>
        public decimal CustoCarteira { get; set; }

        /// <summary>
        /// Listagem dos nomes das paginas
        /// </summary>
        public List<PaginaModelo> Paginas { get; set; }

        public List<CromoModelo> Cromos { get; set; }

    }
}
