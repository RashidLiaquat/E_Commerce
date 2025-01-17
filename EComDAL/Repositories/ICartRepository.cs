using EComDAL.Context;
using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories
{
    internal interface ICartRepository
    {
        IEnumerable<Cart> GetAllCart();
        Cart GetCartById(int id);
        void AddCart(Cart cart);
        void UpdateCart(Cart cart);
        void DeleteCart(int id);
    }

    public class CartRepository : ICartRepository
    {
        private readonly DataContext _context;
        public CartRepository(DataContext context)
        {
            _context = context;
        }
        public void AddCart(Cart cart)
        {
            throw new NotImplementedException();
        }

        public void DeleteCart(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetAllCart()
        {
            throw new NotImplementedException();
        }

        public Cart GetCartById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCart(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
