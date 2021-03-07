
using ECommerce.BLL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.DAL.Repositories.Interfaces
{
    /// <summary>
    /// For our custom user repository, we're going to inherent the minimum required interfaces to implement identity.  There are others for more complex examples and for newer
    /// implementations we can even do all of this with claims.
    /// </summary>
    public interface IUserRepository 
    {
        Task<IList<User>> GetAll();
    }
}
