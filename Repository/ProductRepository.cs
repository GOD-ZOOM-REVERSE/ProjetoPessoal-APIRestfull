using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjetoPessoal.Data.VOs;
using ProjetoPessoal.Model;
using ProjetoPessoal.Model.Context;

namespace ProjetoPessoal.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly BaseContext _context;
        private IMapper _mapper;

        public ProductRepository(BaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> GetProductsAsync()
        {
            return _mapper.Map<IEnumerable<ProductVO>>(await _context.Products.ToListAsync());
        }

        public async Task<ProductVO> GetProductByIdAsync(long id)
        {
            return _mapper.Map<ProductVO>(await _context.Products.FirstAsync(f => f.Id == id));
        }

        public async Task SaveProductAsync(ProductVO productVO)
        {
            var product = _mapper.Map<Product>(productVO);
            product.CreatedAt = DateTime.Now;
            product.UpdatedAt = DateTime.Now;
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<string> UpdateProductAsync(ProductVO productVO)
        {
            if (!(await _context.Products.AnyAsync(p => p.Id == productVO.Id))) throw new Exception("O ID não corresponde a nenhum produto!");
            var product = _mapper.Map<Product>(productVO);
            product.UpdatedAt = DateTime.Now;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return "Atualizado com sucesso!";
        }

        public async Task<string> DeleteProductAsync(long id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) throw new Exception("Produto não encontrado!");
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return "Deletado com sucesso!";
        }
    }
}
