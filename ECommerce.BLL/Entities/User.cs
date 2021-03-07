using System;

namespace ECommerce.BLL.Entities
{
    /// <summary>
    /// Custom fields for your user object.  Id, UserName, PasswordHash and SecurityStamp are all required by Identity.
    /// TODO:  Add your own custom fields.  Don't forget to update the database table and your SQL queries in the user repository
    /// </summary>
    public class User 
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
       
    }
}
