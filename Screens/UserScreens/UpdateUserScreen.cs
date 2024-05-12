using Blog.Models;
using Blog.Repositories;


namespace Blog.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
          public static void Load()
        {
            Console.Clear();
            UpdateUser();
        }

        private static void UpdateUser()
        {
            var repositorio = new Repository<User>(Database.Connection);
            Console.WriteLine("Selecione o id do usuário a ser atualizado");
            var users = repositorio.GetAll();
            foreach(var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name}");
            }
            var option = short.Parse(Console.ReadLine()!);
            var usuarioAtulizar = repositorio.GetDetalhado(option);

            Console.Clear();
            Console.WriteLine("Digite seu novo nome e sobrenome:");
            var name = Console.ReadLine();

            Console.WriteLine("Digite seu novo email:");
            var email = Console.ReadLine();

            Console.WriteLine("Digite sua nova senha:");
            var password = Console.ReadLine();

            Console.WriteLine("Digite sua nova slug:");
            var slug = Console.ReadLine();

            usuarioAtulizar.Name = name !;
            usuarioAtulizar.Email = email !;
            usuarioAtulizar.HashPassword = password !;
            usuarioAtulizar.Slug = slug !;

            try
            {
                repositorio.Update(usuarioAtulizar);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ops, houve um erro: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Operação finalizada");
            }
            
        }
        
    }
}