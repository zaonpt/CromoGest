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
        private const string bdCasa = "CromoGestBDCasa";
        private const string bdLuso = "CromoGestBDLuso";
        private const string bd = bdCasa;

        /// <summary>
        /// Apaga da BD toda a informação sobre esta caderneta. Incluido paginas e cromos.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCaderneta(int id)
        {
            if (id == 0) return;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", id);
                connection.Execute("dbo.spApagaCaderneta", p, commandType: CommandType.StoredProcedure);
            }
            return;
        }
        /// <summary>
        /// Cria uma Caderneta na Base de dados MS SQL 
        /// </summary>
        /// <param name="Caderneta">Caderneta a inserir</param>
        /// <returns>Caderneta que foi inserida</returns>
        public void NewCaderneta(CadernetaModelo caderneta)
        {
            if (caderneta == null) return;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@Nome", caderneta.Nome);
                p.Add("@QuantidadeCromos", caderneta.QuantidadeCromos);
                p.Add("@QuantidadeCromosCarteira", caderneta.QuantidadeCromosCarteira);
                p.Add("@CustoCarteira", caderneta.CustoCarteira);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCriaCaderneta", p, commandType: CommandType.StoredProcedure);

                caderneta.Id = p.Get<int>("@id");
            }
        }
                     
        /// <summary>
        /// Procura e retorna os dados de uma caderneta, dado um nome
        /// </summary>
        /// <param name="nome">Nome da caderneta que queremos procurar</param>
        /// <returns>Devolve a caderneta com o nome fornecido</returns>
        public CadernetaModelo GetCadernetaByNome(string nome)
        {
            if (nome == null) return null;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                CadernetaModelo caderneta;
                var p = new DynamicParameters();
                p.Add("@nome", nome);
                caderneta = connection.Query<CadernetaModelo>("dbo.spGetCadernetaByNome", p, commandType: CommandType.StoredProcedure).ToList()[0];
                return null;
            }
        }

        /// <summary>
        /// Procura na BD e devolve todas as cadernetas
        /// </summary>
        /// <returns>Devolve uma Lista com as cadernetas todas.</returns>
        public List<CadernetaModelo> GetCadernetas()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                List<CadernetaModelo> cadernetas;
                List<PaginaModelo> paginas;
                List<CromoModelo> cromos;
                DynamicParameters p;
                cadernetas = connection.Query<CadernetaModelo>("dbo.spGetCadernetas", commandType: CommandType.StoredProcedure).ToList();

                foreach (CadernetaModelo caderneta in cadernetas)
                {
                    p = new DynamicParameters();
                    p.Add("@IdCaderneta", caderneta.Id);
                    paginas = connection.Query<PaginaModelo>("dbo.spGetPaginasByCadernetaId", p, commandType: CommandType.StoredProcedure).ToList();
                    if (paginas == null) return cadernetas;
                    caderneta.Paginas = paginas;

                    foreach (PaginaModelo pagina in paginas)
                    {
                        p = new DynamicParameters();
                        p.Add("@IdPagina", pagina.Id);
                        cromos = connection.Query<CromoModelo>("dbo.spGetCromosByPaginaId", p, commandType: CommandType.StoredProcedure).ToList();
                        if (cromos == null) return cadernetas;
                        pagina.Cromos = cromos;
                        //pagina.set_pagina_property();
                    }
                }
                return cadernetas;
            }
        }

        public string GetConfig(string desc)
        {
            if (desc == null) return null;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@Desc", desc);
                return connection.Query<string>("spGetConfig", p, commandType: CommandType.StoredProcedure).ToList()[0];
            }
        }

        /// <summary>
        /// Incrementa cromo na colecao, se for novo devolve true.
        /// </summary>
        /// <param name="numero">Numero do cromo</param>
        /// <returns>true se for novo</returns>
        public int IncCromoQuatidade(string numero, int idCaderneta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                int id = GetCromoId(numero, idCaderneta);
                var p = new DynamicParameters();
                p.Add("@Id", id);
                int inseridos = connection.Query<int>("spIncCromoQuantidade", p, commandType: CommandType.StoredProcedure).ToList()[0];
                return inseridos;
            }
        }

        /// <summary>
        /// Decrementa a quantidade deste cromo
        /// </summary>
        /// <param name="cromoNumero">Cromo a decremetar</param>
        /// <param name="idCadernetaSelecionada">ID da caderneta que o cromo pertence</param>
        public int DecCromoQuatidade(string cromoNumero, int idCadernetaSelecionada)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                int id = GetCromoId(cromoNumero, idCadernetaSelecionada);
                var p = new DynamicParameters();
                p.Add("@Id", id);
                int inseridos = connection.Query<int>("spDecCromoQuantidade", p, commandType: CommandType.StoredProcedure).ToList()[0];
                return inseridos;
            }
        }


        public int GetCromoQuatidade(string cromo, int idCaderneta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                int id = GetCromoId(cromo, idCaderneta);
                var p = new DynamicParameters();
                p.Add("@Id", id);
                int inseridos = connection.Query<int>("spGetCromoCountById", p, commandType: CommandType.StoredProcedure).ToList()[0];
                return inseridos;
            }
        }

        /// <summary>
        /// Saca o Id de um cromo atraves do numero, relativamente a uma caderneta (ID)
        /// </summary>
        /// <param name="numero">Numero do cromo</param>
        /// <param name="idCadernta">Identificador da caderneta</param>
        /// <returns></returns>
        public int GetCromoId(string numero, int idCadernta)
        {
            //if (numero == null) return n;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@Numero", numero);
                p.Add("@IdCaderneta", idCadernta);
                var result = connection.Query<int>("spGetCromoIdByNumero", p, commandType: CommandType.StoredProcedure);
                if (result.Count() == 0) return -1;
                return result.ToList()[0];
            }
        }

        /// <summary>
        /// populaciona a caderneta na base de dados com as informacoes dos cromos.
        /// </summary>
        /// <param name="caderneta"></param>
        /// <returns></returns>
        public void PopulateCaderneta(CadernetaModelo caderneta)
        {

            if (caderneta == null) return;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
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
        }

        /// <summary>
        /// Contabiliza a quantidade de cromos aquiridos (e introduzidos na BD)
        /// </summary>
        /// <param name="IdCaderneta">Quantidade de cromos adquiridos</param>
        /// <returns></returns>
        public bool GotCromos(CadernetaModelo idCaderneta)
        {
            if (idCaderneta == null) return false;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@IdCaderneta", idCaderneta.Id);

                int r = connection.Query<int>("spTotalCromosAdquiridos", p, commandType: CommandType.StoredProcedure).ToList()[0];
                return r > 0;
            }
        }

        /// <summary>
        /// Contabiliza a quantidade de cromos que a caderneta tem populados
        /// </summary>
        /// <param name="IdCaderneta">Quantidade de cromos populados</param>
        /// <returns></returns>
        public int TotalCromos(CadernetaModelo Caderneta)
        {
            if (Caderneta == null) return 0;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@IdCaderneta", Caderneta.Id);

                int r = connection.Query<int>("spTotalCromos", p, commandType: CommandType.StoredProcedure).ToList()[0];
                return r;
            }
        }

        /// <summary>
        /// Verifica se existe o cromo na caderneta
        /// </summary>
        /// <param name="cromo"></param>
        /// <param name="idCaderneta"></param>
        /// <returns>booleano que diz se é valido ou não</returns>
        public bool IsValidCromo(string cromo, int idCaderneta)
        {
            if (cromo == null) return false;
            int cromoId = GetCromoId(cromo, idCaderneta);
            if (cromoId == -1) return false;
            return true;
        }


        /// <summary>
        /// Procura e devolve as trocas de existentes de uma dada caderneta.
        /// </summary>
        /// <param name="caderneta">Caderneta das trocas</param>
        /// <returns>Trocas da cadernta</returns>
        public List<TrocaModelo> GetTrocas(CadernetaModelo caderneta)
        {
            if (caderneta == null) return null;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnStringLocalDB(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@IdCaderneta", caderneta.Id);
                List<TrocaModelo> trocas = connection.Query<TrocaModelo>("spGetTrocas", p, commandType: CommandType.StoredProcedure).ToList();

                foreach(TrocaModelo troca in trocas)
                {
                    p = new DynamicParameters();
                    p.Add("@Id", troca.Id);
                    p.Add("@IsRecebido", "0");
                    troca.CromosEnviados = connection.Query<CromoModelo>("spGetCromosDaTroca", p, commandType: CommandType.StoredProcedure).ToList();
                    p.Add("@IsRecebido", "1");
                    troca.CromosRecebidos = connection.Query<CromoModelo>("spGetCromosDaTroca", p, commandType: CommandType.StoredProcedure).ToList();
                }
                return trocas;
            }
        }
    }
}
