using ProjetoPessoal.Model.Base;

namespace ProjetoPessoal.Model
{
    public class Product : BaseEntity
    {
        public string Nome { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Categories Category { get; set; }
        public enum Categories
        {
            Roupas = 1,
            Sapatos = 2,
            Chapeus = 3,
            Acessorios = 4
        }
    }
}
