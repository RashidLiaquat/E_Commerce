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

            var category = await categoryExists.AnyAsync(c => c.Id == subCategorydto.CategoryId);
            var SubCategory = await SubCategoryExists.AnyAsync(c => c.Sub_Category_Name == subCategorydto.Sub_Category_Name);

            if (category && !SubCategory)
            {
                var map = _mapper.Map<SubCategory>(subCategorydto);
                subCategorydto.Created_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
                subCategorydto.Created_Date = DateTime.Now;
                _context.Set<SubCategory>().Add(map);
                await _context.SaveChangesAsync();
            }

            else
            {
                throw new KeyNotFoundException($"Category allready Exists");
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

        public async Task<IEnumerable<SubCategory>> GetAllSubCategories()
        {
            var subCategories = _context.SubCategories;
            if (subCategories == null)
            {
                throw new KeyNotFoundException($"SubCategory List Empty");
            }

            var result = await subCategories.Where(x => x.IsActive == true).ToListAsync();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new KeyNotFoundException($"SubCategory List Empty");
            }

        }

        public async Task<SubCategory> GetsubCategoryById(int Id)
        {
            var CheckContextresult = _context.SubCategories;
            if (CheckContextresult == null)
            {
                throw new KeyNotFoundException($"SubCategories is Empty");
            }
            var result = await CheckContextresult.Where(x => x.Id == Id && x.IsActive == true).FirstOrDefaultAsync();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new KeyNotFoundException($"SubCategory Not Found");
            }
        }

        public async Task UpdateSubCategory(SubCategorydto subCategorydto, int Id)
        {
            var checkcontext = _context.SubCategories;
            if (checkcontext == null)
            {
                throw new KeyNotFoundException($"SubCategories is Empty");
            }
            var result = await checkcontext.Where(x => x.Id == Id && x.IsActive == true).FirstOrDefaultAsync();
            if (result != null)
            {
                _mapper.Map(subCategorydto, result);
                subCategorydto.Updated_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
                subCategorydto.Updated_Date = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"SubCategory Not Found");
            }
        }
    }
}
