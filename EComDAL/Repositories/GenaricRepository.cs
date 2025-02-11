using EComDAL.Context;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Http;

namespace EComDAL.Repositories
{
    public class GenaricRepository : IGenaricRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly DataContext _context;

        public GenaricRepository(IHttpContextAccessor httpContextAccessor, DataContext dataContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = dataContext;
        }

        public User? GetCurrentUser()
        {
            var httpcontext = _httpContextAccessor.HttpContext;
            if (httpcontext == null)
            {
                return null;
            }
            var user = httpcontext.User;
            if (user?.Identity?.Name == null)
            {
                return null;
            }

            var currentUser = _context.Users?.FirstOrDefault(u => u.UserName == user.Identity.Name);
            if (currentUser == null)
            {
                return null;
            }

            return currentUser;
        }
    }
}
