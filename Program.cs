using System;
using Microsoft.Data.SqlClient;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Blog.Repositories;
namespace Blog
{

    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=BLOG;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";
        static void Main(string[] args)
        {
            var _connection = new SqlConnection(CONNECTION_STRING);
            var repositorios = new UserRepository(_connection);
            
        }

        
      
        
    }
}

