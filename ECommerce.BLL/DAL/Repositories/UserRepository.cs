using Dapper;
using ECommerce.BLL.Entities;
using ECommerce.BLL.Repositories;
using ECommerce.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.DAL.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        /// <summary>
        /// User Repository constructor passing injected connection factory to the Base Repository
        /// </summary>
        /// <param name="connectionFactory">The injected connection factory.  It is injected with the constructor argument that is the connection string.</param>
        public UserRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        /// <summary>
        /// INSERT operation for a new user.
        /// </summary>
        /// <param name="user">The User object must be passed in.  We create this during the Register Action.</param>
        /// <returns>Returns a 0 or 1 depending on whether operation is successful or not.</returns>
        public async Task<IList<User>> GetAll()
        {
           return await WithConnection(async connection =>
            {
                string query = "select * from aspnetusers";

                return  (await connection.QueryAsync<User>(query)).ToList();
            });
        }

        public async Task Insert()
        {
             await WithConnection(async connection =>
            {
                string query = "INSERT INTO aspnetusers(Id,Email,[EmailConfirmed],PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,UserName) VALUES('asddfasdf','sdf',1,'ddasdf',NULL,NULL,1,1,1,1,'asdf')";

                return (await connection.ExecuteAsync(query));
            });
        }


        public void Dispose()
        {
        }

       
    }
}
