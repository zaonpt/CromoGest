using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary
{
    public class ConfigCategory
    {
        public string Value { get; set; }

        public ConfigCategory(string value) { Value = value; }

        public static ConfigCategory CharSeparador { get { return new ConfigCategory("Separador"); } }
    }
}
