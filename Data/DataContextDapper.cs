using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace QRCodeWebAPI.Data{
    public class DataContextDapper
    {
        private readonly IConfiguration _config;
        public DataContextDapper(IConfiguration config)
        {
            _config = config;
        }         

        public IEnumerable<T> LoadData<T>(String sql)
        {
            IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return connection.Query<T>(sql);
        }
        public T LoadDataSingle<T>(String sql)
        {
            IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return connection.QuerySingle<T>(sql);
        }

        public bool ExecuteSql(String sql)
        {
            IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return connection.Execute(sql) > 0;
        }
        public int ExecuteSqlWithRowCount(String sql)
        {
            IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return connection.Execute(sql);
        }
        public bool ExecuteSqlWithParameters(String sql, DynamicParameters parameters)
        {
            IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return connection.Execute(sql, parameters) > 0;
        }
        public IEnumerable<T> LoadDataWithParameters<T>(String sql, DynamicParameters parameters)
        {
            IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return connection.Query<T>(sql, parameters);
        }
        public T LoadDataSingleWithParameters<T>(String sql, DynamicParameters parameters)
        {
            IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return connection.QuerySingle<T>(sql, parameters);
        }
    }
}