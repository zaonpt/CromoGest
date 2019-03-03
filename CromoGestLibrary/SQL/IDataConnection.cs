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
        void NewCaderneta(CadernetaVerticalModelo caderneta);

        List<CadernetaVerticalModelo> GetCadernetasVerticias();

        void PopulateCaderneta(CadernetaVerticalModelo caderneta);

        int TotalCromos(CadernetaVerticalModelo idCaderneta);

        bool GotCromos(CadernetaVerticalModelo idcaderneta);

        void DeleteCaderneta(int id);

        string GetConfig(string desc);

        bool IncCromoQuatidade(string numero, int idCaderneta);

        bool IsValidCromo(string cromo, int idCaderneta);

        int GetCromoQuatidade(string cromo, int idCaderneta);

        int GetCromoId(string numero, int idCadernta);

    }
}
