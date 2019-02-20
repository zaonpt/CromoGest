using CromoGestLibrary.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }



        public static void InicializarConns(bool MSSQLdatabase)
        {

            if (MSSQLdatabase)
            {
                // TODO - Establecer ligacao
                Connection = new SqlConnector();
            }
        }
    }
}
