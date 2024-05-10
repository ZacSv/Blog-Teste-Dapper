using Blog.Models;
using Blog.Repositories;


namespace Blog.Screens.UserScreens
{
    public static class CreateCategoryScreen
    {
          public static void Load()
        {
            Console.Clear();
            try
            {
                CreateCategory();
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

        private static void CreateCategory()
        {
            var repositorio = new Repository<Category>(Database.Connection);

            Console.WriteLine("Para criarmos uma categoria precisamos de alguns dados da mesma");
            
            Console.WriteLine("Digite o nome da categoria");
            var name = Console.ReadLine();
            Console.WriteLine("Digite uma slug:");
            var slug = Console.ReadLine();
            
            var categoryAdicionar = new Category();
            categoryAdicionar.Name = name;
            categoryAdicionar.Slug = slug;
            repositorio.Create(categoryAdicionar);
            Console.WriteLine("Categoria adicionado com sucesso");
            Console.WriteLine();
        }
    }
}