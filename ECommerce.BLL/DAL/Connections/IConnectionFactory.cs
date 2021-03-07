using System.Data.SqlClient;

namespace ECommerce.DAL.Repositories.Interfaces
{
    public interface IConnectionFactory
    {
        SqlConnection CreateConnection();
    }
}
