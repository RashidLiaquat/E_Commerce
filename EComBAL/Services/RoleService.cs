using EComDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComBAL.Services
{
    internal class RoleService
    {
        private readonly RoleRepository _repository;
        public RoleService(RoleRepository repository)
        {
            _repository = repository;
        }
    }
}
