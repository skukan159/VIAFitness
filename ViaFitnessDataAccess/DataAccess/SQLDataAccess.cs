using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ViaFitnessDataAccess.DataAccess
{
    class SQLDataAccess
    {
        public static string GetConnectionString(string connectionName = "ViaFitnessDatabase")
        {
            //added reference to System.Configuration DLLs
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql, T data, string connectionString = "ViaFitnessDatabase")
        {
            
            using (IDbConnection cnn = new SqlConnection(GetConnectionString(connectionString)))
            {
                return cnn.Query<T>(sql,data).ToList();
            }
        }

        public static int ExecuteData<T>(string sql, T data, string connectionString = "ViaFitnessDatabase")
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString(connectionString)))
            {
                return cnn.Execute(sql, data);
            }
        }

    }
}
