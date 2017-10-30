using System.Collections.Generic;

namespace MyFavoriteWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Site> Sites { get; set; }
    }
}
