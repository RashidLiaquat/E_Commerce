using EComDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComBAL.Services
{
    internal class CartService
    {
        private readonly CartRepository _repository;
        public CartService(CartRepository repository)
        {
            _repository = repository;
        }
    }
}
