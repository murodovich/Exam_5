using Dapper;
using System.Data.SqlClient;

namespace Exam_5
{
    public class Dapper
    {
        public static void GettAll(string tableName, string DatabaseName, string shart)
        {
            using(SqlConnection conn = new SqlConnection($"Server = (localdb)\\MSSQLLocalDB;Database={DatabaseName}; Trusted_Connection = true;"))
            {
                conn.Open();
                string query = $"select * from {tableName} where {shart};";
                var obj = conn.Execute(query) ;
                
                conn.Close();
                              

            }
        }
    }
}
