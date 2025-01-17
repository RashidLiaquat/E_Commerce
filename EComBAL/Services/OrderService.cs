using EComDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComBAL.Services
{
    internal class OrderService
    {
        private readonly OrderRepository _repository;
        public OrderService(OrderRepository repository)
        {
            _repository = repository;
        }
    }
}
