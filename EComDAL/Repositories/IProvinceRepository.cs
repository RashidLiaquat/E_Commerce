using EComDAL.Context;
using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories
{
    internal interface IProvinceRepository
    {
        IEnumerable<Province> GetAllProvince();
        Province GetProvinceById(int id);
        void AddProvince(Province province);
        void UpdateProvince(Province province);
        void DeleteProvince(int id);
    }

    public class ProvinceRepository : IProvinceRepository
    {
        private readonly DataContext _context;
        public ProvinceRepository(DataContext context)
        {
            _context = context;
        }
        public void AddProvince(Province province)
        {
            throw new NotImplementedException();
        }

        public void DeleteProvince(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> GetAllProvince()
        {
            throw new NotImplementedException();
        }

        public Province GetProvinceById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProvince(Province province)
        {
            throw new NotImplementedException();
        }
    }
}
