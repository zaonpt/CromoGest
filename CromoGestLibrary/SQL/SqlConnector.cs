using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CromoGestLibrary.Modelos;
using Dapper;

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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("CromoGestBD")))
            {
                var p = new DynamicParameters();
                p.Add("@Nome", Caderneta.Nome);
                p.Add("@QuantidadeCromos", Caderneta.QuantidadeCromos);
                p.Add("@QuantidadeCromosCarteira", Caderneta.QuantidadeCromosSaqueta);
                p.Add("@CustoCarteira", Caderneta.CustoCarteira);
                p.Add("@id",0,dbType:DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.CriaCaderneta", p, commandType: CommandType.StoredProcedure);

                Caderneta.Id = p.Get<int>("@id");
                return Caderneta;
            }
        }
    }
}
