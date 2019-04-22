using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class TrocaModelo : INotifyPropertyChanged
    {

        private char charSeparador = CromoGestLibrary.GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];

        /// <summary>
        /// Id da base de dados
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numero da Troca usado pelo interface
        /// </summary>
        public int NumTroca
        {
            get { return NumTroca; }
            set
            {
                if (NumTroca != value)
                {
                    NumTroca = value;
                    OnPropertyChanged("NumTroca");
                }
            }
        }

        /// <summary>
        /// Destinatário da troca
        /// </summary>
       // public DestinatarioModelo Destinatario { get; set; } = new DestinatarioModelo();

        public int Dest_Id { get; set; }
        public string Dest_Nome
        {
            get { return Dest_Nome; }
            set
            {
                if (Dest_Nome != value)
                {
                    Dest_Nome = value;
                    OnPropertyChanged("Dest_Nome");
                }
            }
        }
        public string Dest_Iniciais
        {
            get { return Dest_Iniciais; }
            set
            {
                if (Dest_Iniciais != value)
                {
                    Dest_Iniciais = value;
                    OnPropertyChanged("Dest_Iniciais");
                }
            }
        }

        public string Dest_Origem
        {
            get { return Dest_Origem; }
            set
            {
                if (Dest_Origem != value)
                {
                    Dest_Origem = value;
                    OnPropertyChanged("Dest_Origem");
                }
            }
        }

        public string Dest_Reputacao
        {
            get { return Dest_Reputacao; }
            set
            {
                if (Dest_Reputacao != value)
                {
                    Dest_Reputacao = value;
                    OnPropertyChanged("Dest_Reputacao");
                }
            }
        }

        public string Dest_Morada
        {
            get { return Dest_Morada; }
            set
            {
                if (Dest_Morada != value)
                {
                    Dest_Morada = value;
                    OnPropertyChanged("Dest_Morada");
                }
            }
        }

        /// <summary>
        /// Progresso da troca (Altenativas recolhidas da BD)
        /// </summary>
        public string Progresso
        {
            get { return Progresso; }
            set
            {
                if (Progresso != value)
                {
                    Progresso = value;
                    OnPropertyChanged("Progresso");
                }
            }
        }

        /// <summary>
        /// Data em que foi proposta a troca
        /// </summary>
        public DateTime DataProposta
        {
            get { return DataProposta; }
            set
            {
                if (DataProposta != value)
                {
                    DataProposta = value;
                    OnPropertyChanged("DataProposta");
                }
            }
        }

        /// <summary>
        /// Data em que foram enviados os cromos desta troca
        /// </summary>
        public DateTime DataEnvio
        {
            get { return DataEnvio; }
            set
            {
                if (DataEnvio != value)
                {
                    DataEnvio = value;
                    OnPropertyChanged("DataEnvio");
                }
            }
        }

        /// <summary>
        /// Data de receção dos cromos desta troca
        /// </summary>
        public DateTime DataRececao
        {
            get { return DataRececao; }
            set
            {
                if (DataRececao != value)
                {
                    DataRececao = value;
                    OnPropertyChanged("DataRececao");
                }
            }
        }

        /// <summary>
        /// Lista de cromos para envio
        /// </summary>
        public List<CromoModelo> CromosEnviados { get; set; } = new List<CromoModelo>();
        public string ListCromosEnviados { get {return String.Join($"{charSeparador.ToString()} ", CromosEnviados.Select(num => num.Numero)); } }
        public int QuantidadeCromosEnviados { get { return CromosEnviados.Count; } }

        /// <summary>
        /// Lista de cromos para receção
        /// </summary>
        public List<CromoModelo> CromosRecebidos { get; set; } = new List<CromoModelo>();
        public string ListCromosRecebidos { get { return String.Join($"{charSeparador.ToString()} ", CromosRecebidos.Select(num => num.Numero)); } }
        public int QuantidadeCromosRecebidos { get { return CromosRecebidos.Count; } }

        public TrocaModelo(){}

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

        if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
