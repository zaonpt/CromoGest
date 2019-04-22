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

        private readonly char charSeparador = CromoGestLibrary.GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];

        /// <summary>
        /// Id da base de dados
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Numero da Troca usado pelo interface
        /// </summary>
        private int _numTroca;
        public int NumTroca
        {
            get { return _numTroca; }
            set
            {
                if (_numTroca != value)
                {
                    _numTroca = value;
                    OnPropertyChanged("NumTroca");
                }
            }
        }
        
       /// <summary>
       /// Destinatário da troca
       /// </summary>
        public int Dest_Id { get; set; }
        private string _dest_Nome;
        public string Dest_Nome
        {
            get { return _dest_Nome; }
            set
            {
                if (_dest_Nome != value)
                {
                    _dest_Nome = value;
                    OnPropertyChanged("Dest_Nome");
                }
            }
        }

        /// <summary>
        /// Iniciais do Destinatário
        /// </summary>
        private string _dest_Iniciais;
        public string Dest_Iniciais
        {
            get { return _dest_Iniciais; }
            set
            {
                if (_dest_Iniciais != value)
                {
                    _dest_Iniciais = value;
                    OnPropertyChanged("Dest_Iniciais");
                }
            }
        }

        /// <summary>
        /// Origem do Destinatário
        /// </summary>
        private string _dest_Origem;
        public string Dest_Origem
        {
            get { return _dest_Origem; }
            set
            {
                if (_dest_Origem != value)
                {
                    _dest_Origem = value;
                    OnPropertyChanged("Dest_Origem");
                }
            }
        }

        /// <summary>
        /// Reputação do destinatário
        /// </summary>
        private string _dest_reputacao;
        public string Dest_Reputacao
        {
            get { return _dest_reputacao; }
            set
            {
                if (_dest_reputacao != value)
                {
                    _dest_reputacao = value;
                    OnPropertyChanged("Dest_Reputacao");
                }
            }
        }

        /// <summary>
        /// Morada do Destinatário
        /// </summary>
        private string _dest_Morada;
        public string Dest_Morada
        {
            get { return _dest_Morada; }
            set
            {
                if (_dest_Morada != value)
                {
                    _dest_Morada = value;
                    OnPropertyChanged("Dest_Morada");
                }
            }
        }

        /// <summary>
        /// Progresso da troca (Altenativas recolhidas da BD)
        /// </summary>
        private string _progresso;
        public string Progresso
        {
            get { return _progresso; }
            set
            {
                if (_progresso != value)
                {
                    _progresso = value;
                    OnPropertyChanged("Progresso");
                }
            }
        }

        /// <summary>
        /// Data em que foi proposta a troca
        /// </summary>
        private DateTime _dataProposta;
        public DateTime DataProposta
        {
            get { return _dataProposta; }
            set
            {
                if (_dataProposta != value)
                {
                    _dataProposta = value;
                    OnPropertyChanged("DataProposta");
                }
            }
        }

        /// <summary>
        /// Data em que foram enviados os cromos desta troca
        /// </summary>
        private DateTime _dataEnvio;
        public DateTime DataEnvio
        {
            get { return _dataEnvio; }
            set
            {
                if (_dataEnvio != value)
                {
                    _dataEnvio = value;
                    OnPropertyChanged("DataEnvio");
                }
            }
        }

        /// <summary>
        /// Data de receção dos cromos desta troca
        /// </summary>
        private DateTime _dataRececao;
        public DateTime DataRececao
        {
            get { return _dataRececao; }
            set
            {
                if (_dataRececao != value)
                {
                    _dataRececao = value;
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
