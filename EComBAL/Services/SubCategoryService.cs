using EComDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComBAL.Services
{
    internal class SubCategoryService
    {
        private readonly SubCategoryRepository _repository;

        public SubCategoryService(SubCategoryRepository repository)
        {
            _repository = repository;
        }
    }
}
