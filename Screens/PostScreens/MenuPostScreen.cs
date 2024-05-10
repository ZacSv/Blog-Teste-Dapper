namespace Blog.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de posts");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Criar post");
            Console.WriteLine("2 - Editar post");
            Console.WriteLine("3 - Deletar post");
            Console.WriteLine("4 - Listar todos os posts");
            Console.WriteLine("0 - Voltar ao menu principal");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {   
                case 1:
                    CreatePostScreen.Load();
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