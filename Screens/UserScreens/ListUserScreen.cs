using Azure.Messaging;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        { List();}
        private static void List()
        {
            var repositorio = new Repository<User>(Database.Connection);
            var users = repositorio.GetAll();
            var contador = 0;
            Console.WriteLine("Usuários encontrados");
            Console.WriteLine("--------------------");
            foreach(var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name}");
                contador += 1;
            }
            Console.WriteLine();
            Console.WriteLine($"{contador} usuários encontrados");

        }
        private static void ListForId()
        {
            
        }
    }
}