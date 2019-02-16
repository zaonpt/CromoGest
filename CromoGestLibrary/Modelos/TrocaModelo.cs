using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary
{
    class TrocaModelo
    {
        /// <summary>
        /// Destinatário da troca
        /// </summary>
        public DestinatarioModelo Destinatario { get; set; } = new DestinatarioModelo();

        /// <summary>
        /// Progresso da troca (Altenativas recolhidas da BD)
        /// </summary>
        public string Progresso { get; set; }

        /// <summary>
        /// Data em que foi proposta a troca
        /// </summary>
        public DateTime DataProposta { get; set; }

        /// <summary>
        /// Data em que foram enviados os cromos desta troca
        /// </summary>
        public DateTime DataEnvio { get; set; }

        /// <summary>
        /// Data de receção dos cromos desta troca
        /// </summary>
        public DateTime DataRececao { get; set; }

        /// <summary>
        /// Lista de cromos para envio
        /// </summary>
        public List<CromoModelo> CromosEnviados { get; set; } = new List<CromoModelo>();

        /// <summary>
        /// Lista de cromos para receção
        /// </summary>
        public List<CromoModelo> CromosRecebidos { get; set; } = new List<CromoModelo>();
    }
}
