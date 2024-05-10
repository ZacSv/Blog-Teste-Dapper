using Blog.Screens.UserScreens;

namespace Blog.Screens.CategoryScreens
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categorias");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Criar categoria");
            Console.WriteLine("2 - Editar categoria");
            Console.WriteLine("3 - Deletar categoria");
            Console.WriteLine("4 - Listar todas as categoria");
            Console.WriteLine("0 - Voltar ao menu principal");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {   
                case 1:
                    CreateCategoryScreen.Load();
                    break;
                case 0:
                    Program.Load();
                    break;
                default: 
                    Load();
                    break;

            }
        }
    }
}