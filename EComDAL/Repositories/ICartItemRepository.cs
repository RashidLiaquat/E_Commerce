using EComDAL.Context;
using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories
{
    internal interface ICartItemRepository
    {
        IEnumerable<CartItem> GetAllCartItem();
        CartItem GetCartItemBYId(int id);
        void AddCartItem(CartItem cartItem);
        void UpdateCartItem(CartItem cartItem);
        void DeleteCartItem(int id);
    }

    public class CartItemRepository : ICartItemRepository
    {
        private readonly DataContext _context;
        public CartItemRepository(DataContext context)
        {
            _context = context;
        }
        public void AddCartItem(CartItem cartItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteCartItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CartItem> GetAllCartItem()
        {
            throw new NotImplementedException();
        }

        public CartItem GetCartItemBYId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCartItem(CartItem cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
