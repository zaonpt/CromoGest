using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    class CromoModelo
    {
        /// <summary>
        /// Identificador automático
        /// </summary>
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Caderneta { get; set; }

        public int Posicao { get; set; }

        public int MyProperty { get; set; }
    }
}
