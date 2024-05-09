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
            
            Console.WriteLine("Para acessar um usuário de forma detalhada tecle 1 ou qualquer outra tecla para sair");
            var option = short.Parse(Console.ReadLine()!);
            if (option == 1)
            {
                Console.WriteLine("Digite o id do usuário que deseja acessar (a lista está acima)");
                var user = short.Parse(Console.ReadLine()!);
                var teste = repositorio.GetDetalhado(user);
                var perfis = teste.Roles;
                Console.WriteLine($"ID: {teste.Id}");
                Console.WriteLine($"Nome: {teste.Name}");
                Console.WriteLine($"Bio: {teste.Bio}");
                Console.WriteLine($"Email: {teste.Email}");
                Console.WriteLine($"Slug: {teste.Slug}");
                Console.WriteLine($"Perfis: {teste.Roles}");
                foreach(var role in perfis)
                {
                    Console.WriteLine(role.Name);
                }
            }
        }
    }
}