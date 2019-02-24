﻿using System;
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
        private const string bdCasa = "CromoGestBDCasa";
        private const string bdLuso = "CromoGestBDCasa";
        private const string bd = bdCasa;

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
                p.Add("@QuantidadeCromosCarteira", Caderneta.QuantidadeCromosCarteira);
                p.Add("@CustoCarteira", Caderneta.CustoCarteira);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCriaCaderneta", p, commandType: CommandType.StoredProcedure);

                Caderneta.Id = p.Get<int>("@id");
                return Caderneta;
            }
        }


        /// <summary>
        /// Procura e retorna os dados de uma caderneta, dado um nome
        /// </summary>
        /// <param name="nome">Nome da caderneta que queremos procurar</param>
        /// <returns>Devolve a caderneta com o nome fornecido</returns>
        public CadernetaModelo GetCadernetaByNome(string nome)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(bd)))
            {
                CadernetaModelo caderneta;
                var p = new DynamicParameters();
                p.Add("@nome", nome);
                caderneta = connection.Query<CadernetaModelo>("dbo.spGetCadernetaByNome",p, commandType: CommandType.StoredProcedure).ToList()[0];
                return null;
            }
        }


        /// <summary>
        /// Procura na BD e devolve todas as cadernetas
        /// </summary>
        /// <returns>Devolve uma Lista com as cadernetas todas.</returns>
        public List<CadernetaModelo> GetCadernetas()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(bd)))
            {
                List<CadernetaModelo> cadernetas;
                cadernetas = connection.Query<CadernetaModelo>("dbo.spGetCadernetas").ToList();

                return cadernetas;
            }
        }


        /// <summary>
        /// populaciona a caderneta na base de dados com as informacoes dos cromos.
        /// </summary>
        /// <param name="caderneta"></param>
        /// <returns></returns>
        public bool PopulateCaderneta(CadernetaModelo caderneta)
        {
            bool SemErros = true;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(bd)))
            {
                foreach (PaginaModelo pagina in caderneta.Paginas)
                {
                    var p = new DynamicParameters();
                    p.Add("@Nome", pagina.Nome);
                    p.Add("@IdCaderneta", caderneta.Id);
                    p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spCriaPagina", p, commandType: CommandType.StoredProcedure);
                    pagina.Id = p.Get<int>("@Id");

                    foreach (CromoModelo cromo in pagina.Cromos)
                    {
                        p = new DynamicParameters();
                        p.Add("@Numero", cromo.Numero);
                        p.Add("@Descricao", cromo.Descricao);
                        p.Add("@Quantidade", cromo.Quantidade);
                        p.Add("@IdPagina", pagina.Id);
                        p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        connection.Execute("dbo.spCriaCromo", p, commandType: CommandType.StoredProcedure);
                        cromo.Id = p.Get<int>("@Id");
                    }
                }
            }
            return SemErros;
        }
    }
}
