using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class CadernetaHorizontalModelo
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
        public int QuantidadeCromosCarteira { get; set; }

        /// <summary>
        /// Custo de uma carteira
        /// </summary>
        public decimal CustoCarteira { get; set; }

        public List<PaginaHorizontalModelo> Paginas { get; set; } = new List<PaginaHorizontalModelo>();

        public CadernetaHorizontalModelo() { }

        public CadernetaHorizontalModelo(int id, string nome, int quantidadeCromos, int quantidadeCromosCarteira, decimal custoCarteira)
        {
            Id = id;
            Nome = nome;
            QuantidadeCromos = quantidadeCromos;
            QuantidadeCromosCarteira = quantidadeCromosCarteira;
            CustoCarteira = custoCarteira;
        }


    }
}
