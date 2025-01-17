using EComDAL.Context;
using EComDAL.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories
{
    internal interface IRoleRepository
    {
        IEnumerable<Role> GetAllRole();
        Role GetRoleById(int id);
        void AddRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(int id);
    }

    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext _context;
        public RoleRepository(DataContext context)
        {
            _context = context;
        }
        public void AddRole(Role role)
        {
            throw new NotImplementedException();

        }

        public void DeleteRole(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAllRole()
        {
            var roles = _context.Set<Role>().ToList();

            if (!roles.Any())
            {
                throw new KeyNotFoundException($"Roles list is empty {roles}");
            }

            return roles;
        }

        public Role GetRoleById(int id)
        {
            var result = _context.Set<Role>().Find(id);

            if (result == null)
            {
                throw new KeyNotFoundException($"Role not found {id}");
            }
            return result;
        }

        public void UpdateRole(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
