using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class TrocaModelo
    {
        /// <summary>
        /// Id da base de dados
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numero da Troca usado pelo interface
        /// </summary>
        public int NumTroca { get; set; }

        /// <summary>
        /// Destinatário da troca
        /// </summary>
       // public DestinatarioModelo Destinatario { get; set; } = new DestinatarioModelo();

        public int Dest_Id { get; set; }
        public string Dest_Nome { get; set; }
        public string Dest_Iniciais { get; set; }
        public string Dest_Origem { get; set; }
        public string Dest_Reputacao { get; set; }
        public string Dest_Morada { get; set; }

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
        public string ListCromosEnviados { get {return String.Join(", ", CromosEnviados.Select(num => num.Numero)); } }
        public int QuantidadeCromosEnviados { get { return CromosEnviados.Count; } }

        /// <summary>
        /// Lista de cromos para receção
        /// </summary>
        public List<CromoModelo> CromosRecebidos { get; set; } = new List<CromoModelo>();
        public string ListCromosRecebidos { get { return String.Join(", ", CromosRecebidos.Select(num => num.Numero)); } }
        public int QuantidadeCromosRecebidos { get { return CromosRecebidos.Count; } }

        public TrocaModelo()
        {

        }
    }
}
