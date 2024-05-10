using Blog.Models;
using Blog.Repositories;


namespace Blog.Screens.PerfilScreens
{
    public static class CreateTagScreen
    {
          public static void Load()
        {
            Console.Clear();
            try
            {
                CreateTag();
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

        private static void CreateTag()
        {
            var repositorio = new Repository<Tag>(Database.Connection);

            Console.WriteLine("Para criarmos uma nova tag precisamos de alguns dados da mesma");
            
            Console.WriteLine("Digite o nome da tag:");
            var name = Console.ReadLine();

            Console.WriteLine("Digite uma slug");
            var slug = Console.ReadLine();

            var tagAdicionar = new Tag();
            tagAdicionar.Name = name;
            tagAdicionar.Slug = slug;
            repositorio.Create(tagAdicionar);
            Console.WriteLine("Perfil adicionado com sucesso");
            Console.WriteLine();
        }
    }
}