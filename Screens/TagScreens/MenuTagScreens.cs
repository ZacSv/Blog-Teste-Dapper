

using Blog.Screens.PerfilScreens;

namespace Blog.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de tags");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Criar tag");
            Console.WriteLine("2 - Editar tag");
            Console.WriteLine("3 - Deletar tag");
            Console.WriteLine("4 - Listar todas as tags");
            Console.WriteLine("0 - Voltar ao menu principal");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {   
                case 1:
                    CreateTagScreen.Load();
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