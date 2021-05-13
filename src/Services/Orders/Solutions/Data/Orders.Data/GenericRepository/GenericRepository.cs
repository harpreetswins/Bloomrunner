using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.GenericRepository
{
    public class GenericRepository
    {
        private readonly IConfiguration _configuration;
        public GenericRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        private IDbConnection CreateConnection()
        {
            string cn = _configuration["ConnectionStrings:OrderDbConnection"];
            return new SqlConnection(cn);
        }
        /// <summary>
        /// Generic Method for Select Operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected async Task<IEnumerable<T>> Query<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                var QueryResponse = await connection.QueryAsync<T>(sql: sql, param: parameters, commandType: CommandType.StoredProcedure);
                return QueryResponse;
            }
        }
        /// <summary>
        ///  Generic Methods for Insert,Update and Delete Operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected async Task<int> Command<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                var QueryResponse = await connection.ExecuteAsync(sql: sql, param: parameters, commandType: CommandType.StoredProcedure);

                return QueryResponse;
            }
        }
    }
}
