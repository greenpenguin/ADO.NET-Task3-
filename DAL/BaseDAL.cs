using System.Configuration;

namespace DAL
{
    public class BaseDAL
    {
        protected string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
    }
}
