using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CromoGestLibrary.Modelos;

namespace CromoGestLibrary.SQL
{
    public class SqlConnector : IDataConnection
    {
        // TODO - implementar o metodo.
        /// <summary>
        /// Cria uma Caderneta na Base de dados MS SQL 
        /// </summary>
        /// <param name="Caderneta">Caderneta a inserir</param>
        /// <returns>Caderneta que foi inserida</returns>
        public CadernetaModelo CriarCaderneta(CadernetaModelo Caderneta)
        {
            Caderneta.Id = 1;
            return Caderneta;
        }
    }
}
