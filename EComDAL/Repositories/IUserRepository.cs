using EComDAL.Context;
using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories
{
    internal interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User Adduser(User user);
        void GetUserById(int id);
        void Updateuser(User user);
        void Deleteuser(int Id);
    }

    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public User Adduser(User user)
        {
            throw new NotImplementedException();
        }

        public void AddUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void Deleteuser(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public void GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void Updateuser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
