﻿using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{


    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGenaricRepository _genaricRepository;
        public RoleRepository(DataContext context, IMapper mapper, IGenaricRepository genaricRepository)
        {
            _context = context;
            _mapper = mapper;
            _genaricRepository = genaricRepository;
        }
        public async Task<IEnumerable<Roledto>> GetAllRole()
        {
            var roles = await _context.Set<Role>().ToListAsync();

            if (!roles.Any())
            {
                throw new KeyNotFoundException($"Roles list is empty");
            }

            var roledto = _mapper.Map<List<Roledto>>(roles);
            return roledto;
        }

        public async Task<Role> GetRoleById(int id)
        {
            var result = await _context.Set<Role>().FindAsync(id);

            if (result == null)
            {
                throw new KeyNotFoundException($"Role not found {id}");
            }
            return result;
        }
        public async Task AddRoleAsync(Roledto roledto)
        {
            var result = _mapper.Map<Role>(roledto);

            if (result == null)
            {
                throw new KeyNotFoundException($"Role is not Found {result}");
            }
            result.CreatedBy = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            result.CreatedDate = DateTime.Now;
            await _context.Set<Role>().AddAsync(result);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoleAsync(int Id)
        {
            var result = await _context.Set<Role>().FindAsync(Id);
            if (result == null)
            {
                throw new KeyNotFoundException($"Roles list is empty {result}");
            }

            _context.Set<Role>().Remove(result);
            await _context.SaveChangesAsync();

        }
        public async Task Updated(Roledto roledto, int Id)
        {
            var result = await _context.Set<Role>().FindAsync(Id);
            if (result == null)
            {
                throw new KeyNotFoundException($"Roles is not Found");
            }
            _mapper.Map(roledto, result);

            result.UpdatedBy = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            result.UpdatedDate = DateTime.Now;
            _context.Set<Role>().Update(result);
            _context.SaveChanges();

        }
    }
}
