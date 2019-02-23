using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class CromoModelo
    {
        private string name;

        public CromoModelo(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Identificador automático
        /// </summary>
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
