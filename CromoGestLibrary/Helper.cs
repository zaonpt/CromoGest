using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary
{
    public static class Helper
    {

        public static string CnnVal(string nome)
        {
            return ConfigurationManager.ConnectionStrings[nome].ConnectionString;
        }

    }
}
