using ECommerce.BLL.BLL.Interface;
using ECommerce.BLL.Entities;
using ECommerce.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ECommerce.BLL.BLL.Manger
{
    public class CategoryService : ICategoryService
    {
        private readonly IUserRepository userRepository;

        public CategoryService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        
        public async Task<IList<User>>  GetAll()
        {
            return await userRepository.GetAll();
        }
        public async Task TransacionTest()
        {
            using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                await userRepository.Insert();
                ts.Complete();
            }
        }

    }
}
