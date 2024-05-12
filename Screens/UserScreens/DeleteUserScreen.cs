using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
         public static void Load()
        {
            Console.Clear();
            DeleteUser();
        }

        private static void DeleteUser()
        {
            var repositorio = new Repository<User>(Database.Connection);

            Console.WriteLine("Selecione o id do usuário a ser deletado");
            
            var users = repositorio.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name}");
            }
            var option = short.Parse(Console.ReadLine()!);
            var usuario = repositorio.GetDetalhado(option);
            Console.WriteLine($"Você seleciou o usuário: {usuario.Name}");
            Console.WriteLine("Tem certeza que deseja deletar o usuário \n 1 - SIM \n 2 - NÃO");
            var optionDel = short.Parse(Console.ReadLine()!); 

            if (optionDel == 1)
            {   
                try
                {
                    repositorio.Delete(option);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Operação finalizada"); 
                }
            }
            if(optionDel == 2)
            {
                DeleteUser();
            }
            
       }
    }
}