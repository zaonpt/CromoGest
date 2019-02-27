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
        CadernetaModelo CriarCaderneta(CadernetaModelo caderneta);

        List<CadernetaModelo> GetCadernetas();

        CadernetaModelo PopulateCaderneta(CadernetaModelo caderneta);

        int TotalCromos(CadernetaModelo idCaderneta);

        bool TemCromos(CadernetaModelo idcaderneta);
        void ApagarCaderneta(int id);
    }
}
