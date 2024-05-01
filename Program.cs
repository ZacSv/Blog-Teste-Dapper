using System;
using Microsoft.Data.SqlClient;
using Blog.Models;
using Dapper.Contrib.Extensions;
using System.Runtime.InteropServices;

namespace Blog
{

    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=BLOG;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";
        static void Main(string[] args)
        {
            ReadUser();
        }

        public static void ReadUser()
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
    }
}
