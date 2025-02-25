using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(int Id);
        Task AddProduct(Productdto product);
        Task DeleteProduct(int Id);
        Task UpdateProduct(Productdto product, int Id);

    }
}
