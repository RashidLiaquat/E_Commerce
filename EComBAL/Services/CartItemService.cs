﻿using EComDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComBAL.Services
{
    internal class CartItemService
    {
        private readonly CartItemRepository _repository;
        public CartItemService(CartItemRepository repository)
        {
            _repository = repository;
        }
    }
}
