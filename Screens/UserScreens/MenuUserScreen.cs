namespace Blog.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de usuários");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Criar usuário");
            Console.WriteLine("2 - Editar usuário");
            Console.WriteLine("3 - Deletar usuário");
            Console.WriteLine("4 - Listar todos os usuários");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {   
                case 1:
                    CreateUserScreen.Load();
                    break;
                case 4: 
                    ListUserScreen.Load();
                    break;
                default: 
                    Load();
                    break;

            }
        }
    }
}