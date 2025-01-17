using EComDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComBAL.Services
{
    internal class OrderItemService
    {
        private readonly OrderitemRepository _repository;
        public OrderItemService(OrderitemRepository repository)
        {
            _repository = repository;
        }
    }
}
