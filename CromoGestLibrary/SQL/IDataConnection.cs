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
        CadernetaModelo NewCaderneta(CadernetaModelo caderneta);

        List<CadernetaModelo> GetCadernetas();

        CadernetaModelo PopulateCaderneta(CadernetaModelo caderneta);

        int TotalCromos(CadernetaModelo idCaderneta);

        bool GotCromos(CadernetaModelo idcaderneta);

        void DeleteCaderneta(int id);

        string GetConfig(string desc);

        bool IncCromoQuatidade(string numero, int idCaderneta);

        bool IsValidCromo(string v);


    }
}
