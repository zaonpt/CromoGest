using CromoGestLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.SQL
{
    public interface IDataConnection
    {
        void NewCaderneta(CadernetaModelo caderneta);

        List<CadernetaModelo> GetCadernetas();

        void PopulateCaderneta(CadernetaModelo caderneta);

        int TotalCromos(CadernetaModelo idCaderneta);

        List<TrocaModelo> GetTrocas(CadernetaModelo caderneta);
        List<DestinatarioModelo> GetDestinatarios();
        bool GotCromos(CadernetaModelo idcaderneta);

        void DeleteCaderneta(int id);

        string GetConfig(string desc);

        int IncCromoQuatidade(string numero, int idCaderneta);

        bool IsValidCromo(string cromo, int idCaderneta);

        int GetCromoQuatidade(string cromo, int idCaderneta);

        int GetCromoId(string numero, int idCadernta);

        int DecCromoQuatidade(string cromoNumero, int idCadernetaSelecionada);

        DestinatarioModelo GetDestinatario(int idDest);

        int GetNextTrocaNum(int idCaderneta);

        int SetDestinatario(string Nome, string Iniciais, string Origem, string Reputacao, string Morada);

        int SetTroca(int numTroca, int idDestinatario, string progresso, string dataProposta, string dataEnvio, string dataRececao, int idCaderneta);
        int CriaCromoDaTroca(int idCromo, int idTroca, int isRecebido);
    }
}
