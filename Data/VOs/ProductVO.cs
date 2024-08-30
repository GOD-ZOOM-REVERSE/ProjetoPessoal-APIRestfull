namespace ProjetoPessoal.Data.VOs
{
    public class ProductVO
    {
        public long? Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
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
