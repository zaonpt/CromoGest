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
        CadernetaModelo CriarCaderneta(CadernetaModelo Caderneta);

        List<CadernetaModelo> GetCadernetas();

        bool PopulateCaderneta(CadernetaModelo caderneta);

        int TotalCromos(CadernetaModelo IdCaderneta);

        bool TemCromos(CadernetaModelo Idcaderneta);

    }
}
