using System;
using Microsoft.Data.SqlClient;
using Blog.Models;
using Dapper.Contrib.Extensions;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Blog
{

    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=BLOG;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";
        static void Main(string[] args)
        {
            //ReadUsers();
            //ReadUser();
            //CreateUser();
            //UpdateUser();
            DeleteUser();
        }

        public static void ReadUsers()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.GetAll<User>();
                foreach (var usuario in user)
                {
                    Console.WriteLine(usuario.Name);
                }
            }
        }
        public static void ReadUser()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                Console.WriteLine(user.Name);
            }
        }   
        public static void CreateUser()
        {
            var user = new User()
            {
                Name = "Juscelino",
                Bio = "Teste de Bio",
                Email = "juscelinodasgata@gmail.com",
                HashPassword = "HASH",
                Image = "Sem-Image",
                Slug = "juscelino-dasgatas"
            };
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                var idUser = user.Id;
                var busca_no_banco = connection.Get<User>(idUser);
                Console.WriteLine($"Usuário: {busca_no_banco.Name} inserido no banco com sucesso");
            }
        }  
        public static void UpdateUser()
        {
             var user = new User()
                {
                    Id = 2,
                    Name = "Isac",
                    Bio = "Testando a bio",
                    Email = "isac@gmail.com",
                    HashPassword = "HASH",
                    Image = "https",
                    Slug = "isac"
                };

            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
               connection.Update<User>(user);
               Console.WriteLine("Alteração salva");
            }
        } 
        public static void DeleteUser()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                connection.Delete<User>(user);
                Console.WriteLine($"Usuário deletado no banco com sucesso");
            }
        }  
        
    }
}

