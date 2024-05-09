using Blog.Models;
using Blog.Repositories;


namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
          public static void Load()
        {
            Console.Clear();
            try
            {
                CreateUser();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ops, algo deu errado !" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Operação finalizada");
            }
        }

        private static void CreateUser()
        {
            var repositorio = new Repository<User>(Database.Connection);

            Console.WriteLine("Para criarmos um usuário precisamos de alguns dados do mesmo");
            
            Console.WriteLine("Digite seu nome e sobrenome:");
            var name = Console.ReadLine();

            Console.WriteLine("Digite seu email:");
            var email = Console.ReadLine();

            Console.WriteLine("Digite uma senha:");
            var password = Console.ReadLine();

            Console.WriteLine("Digite uma slug:");
            var slug = Console.ReadLine();
            
            var usuarioAdicionar = new User();
            usuarioAdicionar.Name = name;
            usuarioAdicionar.Email = email;
            usuarioAdicionar.HashPassword = password;
            usuarioAdicionar.Slug = slug;
            repositorio.Create(usuarioAdicionar);
            Console.WriteLine("Usuário adicionado com sucesso");
            Console.WriteLine();
        }
    }
}