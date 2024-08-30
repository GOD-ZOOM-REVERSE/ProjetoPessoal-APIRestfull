using ProjetoPessoal.Data.VOs;

namespace ProjetoPessoal.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> GetProductsAsync();
        Task<ProductVO> GetProductByIdAsync(long id);
        Task SaveProductAsync(ProductVO productVO);
        Task<string> UpdateProductAsync(ProductVO productVO);
        Task<string> DeleteProductAsync(long id);
    }
}
