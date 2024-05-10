using System.Net.NetworkInformation;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            List();
        }
        private static void List()
        {
            var repositorio = new Repository<User>(Database.Connection);
            var users = repositorio.GetAll();
            Console.WriteLine("Usuários encontrados");
            Console.WriteLine("--------------------");
            foreach(var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name}"); 
            }
            
        }
    }
}