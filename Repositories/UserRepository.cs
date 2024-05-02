using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
namespace Blog.Repositories
{
    
    public class UserRepository
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
            => _connection = connection;


        public void ReadUser(int id)
            => _connection.Get<User>(id);

        public IEnumerable<User> Get()
            => _connection.GetAll<User>();
        
        public void CreateUser(User user)
        {
            user.Id = 0;
            _connection.Insert<User>(user); 
        }
            
       
        public void UpdateUser(User user)
        {
            if(user.Id != 0)
            {
                _connection.Update<User>(user);
            }
        }
       
        public void DeleteUser(User user)
        {
            if(user.Id != 0)
            {
                _connection.Delete<User>(user);
            }
        }
        public void DeleteUser(int id) //Sobrecarga visando situação aonde só se insira o ID para o método 'delete'
        {
            if(id != 0)
            {
                return;
            }
            var user = _connection.Get<User>(id);
            _connection.Delete<User>(user);
        }

    }
}