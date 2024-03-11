using Microsoft.Data.SqlClient;
using System.Configuration;

namespace BD_MS
{
    internal class BDWorker
    {
        public async Task Start()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CargosDB"].ConnectionString;
            SqlConnection connection = new SqlConnection();
        }
    }
}
