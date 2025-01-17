using EComDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComBAL.Services
{
    internal class ProvinceService
    {
        private readonly ProvinceRepository _repository;

        public ProvinceService(ProvinceRepository repository)
        {
            _repository = repository;
        }
    }
}
