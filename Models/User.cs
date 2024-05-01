using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[User]")] //Metadata indicando o nome da tabela no banco
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

    }
}