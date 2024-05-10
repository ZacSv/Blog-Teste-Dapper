namespace Blog.Screens.PerfilScreens
{
    public static class MenuPerfilScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de perfil");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Criar perfil");
            Console.WriteLine("2 - Editar perfil");
            Console.WriteLine("3 - Deletar perfil");
            Console.WriteLine("4 - Listar todos os perfil");
            Console.WriteLine("0 - Voltar ao menu principal");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {   
                case 1:
                    CreatePerfilScreen.Load();
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