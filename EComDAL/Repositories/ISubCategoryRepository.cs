using EComDAL.Context;
using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories
{
    internal interface ISubCategoryRepository
    {
        IEnumerable<SubCategory> GetSubCategories();
        SubCategory GetSubCategoryById(int id);
        void AddSubCategory(SubCategory subCategory);
        void UpdateSubCategory(SubCategory subCategory);
        void DeleteSubCategory(int id);
    }

    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly DataContext _context;
        public SubCategoryRepository(DataContext context)
        {
            _context = context;
        }
        public void AddSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            throw new NotImplementedException();
        }

        public SubCategory GetSubCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }
    }
}
