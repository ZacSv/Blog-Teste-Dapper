using Blog.Models;
using Blog.Repositories;


namespace Blog.Screens.PerfilScreens
{
    public static class CreatePerfilScreen
    {
          public static void Load()
        {
            Console.Clear();
            try
            {
                CreatePerfil();
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

        private static void CreatePerfil()
        {
            var repositorio = new Repository<Role>(Database.Connection);

            Console.WriteLine("Para criarmos um perfil novo precisamos de alguns dados do mesmo");
            
            Console.WriteLine("Digite o nome do perfil:");
            var name = Console.ReadLine();

            Console.WriteLine("Digite uma slug");
            var slug = Console.ReadLine();

            var perfilAdicionar = new Role();
            perfilAdicionar.Name = name;
            perfilAdicionar.Slug = slug;
            repositorio.Create(perfilAdicionar);
            Console.WriteLine("Perfil adicionado com sucesso");
            Console.WriteLine();
        }
    }
}