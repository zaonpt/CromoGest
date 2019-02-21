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
        private const string bd = "CromoGestBD";
        // TODO - implementar o metodo.
        /// <summary>
        /// Cria uma Caderneta na Base de dados MS SQL 
        /// </summary>
        /// <param name="Caderneta">Caderneta a inserir</param>
        /// <returns>Caderneta que foi inserida</returns>
        public CadernetaModelo CriarCaderneta(CadernetaModelo Caderneta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@Nome", Caderneta.Nome);
                p.Add("@QuantidadeCromos", Caderneta.QuantidadeCromos);
                p.Add("@QuantidadeCromosCarteira", Caderneta.QuantidadeCromosSaqueta);
                p.Add("@CustoCarteira", Caderneta.CustoCarteira);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCriaCaderneta", p, commandType: CommandType.StoredProcedure);

                Caderneta.Id = p.Get<int>("@id");
                return Caderneta;
            }
        }

        public List<CadernetaModelo> GetCadernetas()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(bd)))
            {
                List<CadernetaModelo> cadernetas;
                cadernetas = connection.Query<CadernetaModelo>("dbo.spGetCadernetas").ToList();

                return cadernetas;
            }
        }
    }
}
