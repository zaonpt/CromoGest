using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class CadernetaVerticalModelo
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

        public List<PaginaVerticalModelo> Paginas { get; set; } = new List<PaginaVerticalModelo>();

        public CadernetaVerticalModelo() { }

        public CadernetaVerticalModelo(string nome, string quantidade, string quantidadeSaqueta, string custoSaqueta)
        {
            // TODO : Validar esta informacao e dar lidar com informacao incorreta
            Nome = nome;
            int.TryParse(quantidade, out int quantidadeCromos);
            QuantidadeCromos = quantidadeCromos;
            int.TryParse(quantidadeSaqueta, out int quantidadeCromosSaqueta);
            QuantidadeCromosCarteira = quantidadeCromosSaqueta;
            decimal.TryParse(custoSaqueta, out decimal custoCarteira);
            CustoCarteira = custoCarteira;
        }

    }
}
