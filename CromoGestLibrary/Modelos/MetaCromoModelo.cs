using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    class MetaCromoModelo
    {
        /// <summary>
        /// Identificador automático.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Posicao na caderneta
        /// </summary>
        public int Posicao { get; set; }

        /// <summary>
        /// Pagina a que pretence o cromo.
        /// </summary>
        public string Pagina { get; set; }

        /// <summary>
        /// Nome do Cromo. Normalmente é um número, mas às vezes são alftanuméricos tipo 63A.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descrição do cromo, o nome do jogador, do animal ou do que seja.
        /// </summary>
        public string Descricao { get; set; }

    }
}
