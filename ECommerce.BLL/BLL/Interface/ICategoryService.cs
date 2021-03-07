using ECommerce.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.BLL.Interface
{
    public interface ICategoryService
    {
        Task<IList<User>> GetAll();
        Task TransacionTest();
    }
}
