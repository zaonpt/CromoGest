using CromoGestLibrary.SQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }


        public static void InicializarConns(ConnType connType)
        {
            if (connType == ConnType.LOCALDB)
            {
                // TODO - Establecer ligacao
                Connection = new SqlConnector();
            }
        }

        public static string CnnStringLocalDB(string name)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
