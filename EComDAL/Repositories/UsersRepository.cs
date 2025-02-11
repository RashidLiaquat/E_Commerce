using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGenaricRepository _genaricRepository;
        public UsersRepository(DataContext dataContext, IMapper mapper, IGenaricRepository genaricRepository)
        {
            _context = dataContext;
            _mapper = mapper;
            _genaricRepository = genaricRepository;
        }
        public async Task AddUser(Userdto userdto)
        {
            var CurrentUser = _genaricRepository.GetCurrentUser();
            if (CurrentUser == null)
            {
                throw new InvalidOperationException("User not found");
            }

            if (_context.Users == null)
            {
                throw new InvalidOperationException("Users DbSet is null");
            }

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == userdto.Email && u.UserName == userdto.UserName);
            if (existingUser != null)
            {
                throw new KeyNotFoundException("UserName or Email already exists");
            }
            var users = new User
            {
                FullName = userdto.FullName,
                UserName = userdto.UserName,
                Email = userdto.Email,
                Password = userdto.Password,
                GenderStatus = userdto.Gender,
                ProfilePic = userdto.ProfilePic,
                Address = userdto.Address,
                RoleId = userdto.RoleId,
                ProvinceId = userdto.ProvinceId,
                CreatedBy = CurrentUser?.UserName ?? throw new InvalidOperationException("Current user is null"),
            };
            users.Password = BCrypt.Net.BCrypt.HashPassword(users.Password);

            await _context.Set<User>().AddAsync(users);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int Id)
        {
            if (_context.Users == null)
            {
                throw new InvalidOperationException("Users DbSet is null");
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == Id);
            if (user == null)
            {
                throw new KeyNotFoundException("User not found");
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
        public async Task SoftDelete(int id)
        {
            if (_context.Users == null)
            {
                throw new InvalidOperationException("Users DbSet is null");
            }
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                throw new KeyNotFoundException("User not found");
            }
            user.IsActive = false;
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            if (_context.Users == null)
            {
                throw new InvalidOperationException("Users DbSet is null");
            }

            var result = await _context.Users.Where(x => x.IsActive == true).ToListAsync();

            return result;

        }

        public async Task<User> GetUserById(int Id)
        {
            if (_context.Users == null)
            {
                throw new InvalidOperationException("Users DbSet is null");
            }

            var result = await _context.Users.Where(x => x.IsActive == true && x.Id == Id).FirstOrDefaultAsync();

            if (result == null)
            {
                throw new InvalidOperationException("User Not Found");
            }

            return result;
        }

        public async Task UpdateUser(UserUpdatedto userdto, int Id)
        {
            var CurrentUser = _genaricRepository.GetCurrentUser();

            if (_context.Users == null)
            {
                throw new InvalidOperationException("Users DbSet is null");
            }

            var result = await _context.Users.Where(x => x.IsActive == true && x.Id == Id).FirstOrDefaultAsync();

            if (result == null)
            {
                throw new InvalidOperationException("User Not Found");
            }

            _mapper.Map(userdto, result);
            result.UpdatedBy = CurrentUser?.UserName ?? throw new InvalidOperationException("Current user is null");
            _context.Set<User>().Update(result);
            await _context.SaveChangesAsync();
        }
    }
}
