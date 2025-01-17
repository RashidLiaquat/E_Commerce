using EComDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComBAL.Services
{
    internal class CategoryService
    {
        private readonly CategoryRepository _repository;
        public CategoryService(CategoryRepository repository)
        {
            _repository = repository;
        }
    }
}
