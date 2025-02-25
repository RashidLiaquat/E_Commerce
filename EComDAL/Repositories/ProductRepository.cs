using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;
        private readonly IGenaricRepository _genaricRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapp;

        public ProductRepository(DataContext dataContext, IGenaricRepository genaricRepository, IProductRepository productRepository, IMapper mapper)
        {
            _context = dataContext;
            _genaricRepository = genaricRepository;
            _productRepository = productRepository;
            _mapp = mapper;
        }

        public async Task AddProduct(Productdto product)
        {
            var productExists = await _context.Products.AnyAsync(c => c.Id == product.Id && c.IsActive);

            var userExists = await _context.Users.AnyAsync(c => c.Id == product.Id && c.IsActive);

            if (productExists || !userExists)
            {
                throw new KeyNotFoundException("Either the product already exists or the user does not exist or is not active.");
            }

            var map = _mapp.Map<Product>(product);

            await _context.Set<Product>().AddAsync(map);
            await _context.SaveChangesAsync();
        }



        public async Task DeleteProduct(int id)
        {
            var product = await _context.Products
                .Where(c => c.Id == id && c.IsActive)
                .FirstOrDefaultAsync();

            if (product == null)
            {
                throw new KeyNotFoundException("Product not found or is not active.");
            }

            var userExists = await _context.Users
               .AnyAsync(u => u.Id == product.Id && u.IsActive);

            if (!userExists)
            {
                throw new KeyNotFoundException("User associated with the product does not exist or is not active.");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var result = await _context.Products.Where(p => p.IsActive == true)
                .Include(c => c.CategoryId)
                .ToListAsync();

            return result;
        }

        public async Task<Product> GetProduct(int Id)
        {
            var result = await _context.Products
                .Where(p => p.Id == Id && p.IsActive)
                .Include(p => p.Category)
                .FirstOrDefaultAsync();
            if (result == null)
            {
                throw new KeyNotFoundException($"Product is Empty");
            }

            return result;
        }

        public async Task UpdateProduct(Productdto product, int Id)
        {
           var result = await _context.Products
                .Include(c => c.Category)
                .FirstOrDefaultAsync(p => p.Id == Id && p.IsActive);
            if (result == null)
            {
                throw new KeyNotFoundException($"Product with ID {Id} not found or inactive.");
            }
            _mapp.Map(product, result);
            await _context.SaveChangesAsync();
        }
    }
}
