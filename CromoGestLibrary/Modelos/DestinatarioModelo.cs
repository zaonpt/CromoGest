using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    class DestinatarioModelo
    {
        /// <summary>
        /// Identificador automático
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Nome do destinatário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Iniciais do destinatário
        /// </summary>
        public string Iniciais { get; set; }

        /// <summary>
        /// Origem do Destinatário.
        /// </summary>
        public string Origem { get; set; }

        /// <summary>
        /// Reputação do destinatário usada pelo forum de trocas
        /// </summary>
        public string Reputacao { get; set; }

        /// <summary>
        /// Morada do Destinatário
        /// </summary>
        public string Morada { get; set; }

    }
}
