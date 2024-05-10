using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreens;
using Blog.Screens.UserScreens;


namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
          public static void Load()
        {
            Console.Clear();
            try
            {
                CreatePost();
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
        private static void CreatePost()
        {
            var repositorio = new Repository<Post>(Database.Connection);
            
            Console.WriteLine("Para criarmos um post novo precisamos de alguns dados do mesmo");
            
            Console.WriteLine("Digite o título do post:");
            var name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Escreva um pequeno resumo de seu post");
            var summary = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Escreva o seu post:");
            var body = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Digite uma slug");
            var slug = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Agora precisamos definir uma categoria para o seu post, escolha uma das listadas abaixo: ");
            ListCategoryScreen.Load();
            var category = short.Parse(Console.ReadLine()!);

            Console.Clear();
            Console.WriteLine("Selecione o autor do seu post abaixo");
            ListUserScreen.Load();
            int author = short.Parse(Console.ReadLine()!);

            var postAdicionar = new Post();

            postAdicionar.AuthorId = author;
            postAdicionar.CategoryId = category;
            postAdicionar.Body = body;
            postAdicionar.Title = name;
            postAdicionar.Summary = summary;
            postAdicionar.Slug = slug;

            repositorio.Create(postAdicionar);
        }
    }
}