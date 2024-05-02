using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Blog.Repositories
{

     public class RoleRepository
     {
        private readonly SqlConnection _connection;

        public RoleRepository(SqlConnection connection)
            => _connection = connection;


      public void ReadRole(int id)
            => _connection.Get<Role>(id);

        public IEnumerable<Role> GetRoles()
            => _connection.GetAll<Role>();
        
        public void CreateRole(Role role)
        {
            role.Id = 0;
            _connection.Insert<Role>(role); 
        }
            
       
        public void UpdateRole(Role role)
        {
            if(role.Id != 0)
            {
                _connection.Update<Role>(role);
            }
        }
       
        public void DeleteUser(Role role)
        {
            if(role.Id != 0)
            {
                _connection.Delete<Role>(role);
            }
        }
        public void DeleteUser(int id) //Sobrecarga visando situação aonde só se insira o ID para o método 'delete'
        {
            if(id != 0)
            {
                return;
            }
            var role = _connection.Get<Role>(id);
            _connection.Delete<Role>(role);
        }

     }


}