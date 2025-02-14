using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGenaricRepository _genaricRepository;

        public SubCategoryRepository(DataContext context, IMapper mapper, IGenaricRepository genaricRepository)
        {
            _context = context;
            _mapper = mapper;
            _genaricRepository = genaricRepository;
        }

        public async Task AddSubCategory(SubCategorydto subCategorydto)
        {
            var categoryExists = _context.Categories;
            var SubCategoryExists = _context.SubCategories;
            if (categoryExists == null)
            {
                throw new KeyNotFoundException($"Category is Empty");
            }
            if (SubCategoryExists == null)
            {
                throw new KeyNotFoundException($"SubCategory is Empty");
            }

            var category = await categoryExists.AnyAsync(c => c.Id == subCategorydto.Id);
            var SubCategory= await SubCategoryExists.AnyAsync(c => c.Sub_Category_Name == subCategorydto.Sub_Category_Name);

            if (category && ! SubCategory)
            {
                var map = _mapper.Map<SubCategory>(subCategorydto);
                _context.Set<SubCategory>().Add(map);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteSubCategory(int Id)
        {
           var checkcontext = _context.SubCategories;
            if (checkcontext == null)
            {
                throw new KeyNotFoundException($"SubCategories is Empty");
            }
            var result = await checkcontext.Where(x => x.Id == Id && x.IsActive).FirstOrDefaultAsync();

            if (result != null)
            {
                _context.Set<SubCategory>().Remove(result);
                await _context.SaveChangesAsync();
            }

            else
            {
                throw new KeyNotFoundException($"SubCategory Not Found");
            }
        }

        public Task<IEnumerable<SubCategory>> GetAllSubCategories()
        {
            throw new NotImplementedException();
        }

        public Task<SubCategory> GetsubCategoryById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSubCategory(SubCategorydto subCategorydto, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
