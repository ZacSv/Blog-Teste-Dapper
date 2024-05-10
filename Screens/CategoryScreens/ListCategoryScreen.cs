using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            List();
        }
        private static void List()
        {
            var repositorio = new Repository<Category>(Database.Connection);
            var category = repositorio.GetAll();
            Console.WriteLine("Categorias disponíveis");
            Console.WriteLine("--------------------");
            foreach(var categoryS in category)
            {
                Console.WriteLine($"{categoryS.Id} - {categoryS.Name}"); 
            }
        }
    }
}