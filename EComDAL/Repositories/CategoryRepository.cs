using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGenaricRepository _genaricRepository;

        public CategoryRepository(DataContext dataContext, IMapper mapper, IGenaricRepository genaricRepository)
        {
            _context = dataContext;
            _mapper = mapper;
            _genaricRepository = genaricRepository;
        }
        public async Task AddCategory(Categorydto categorydto)
        {
            var result = _mapper.Map<Category>(categorydto);
            if (result == null)
            {
                throw new KeyNotFoundException($"Category not found");
            }
            categorydto.Created_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            categorydto.Created_Date = DateTime.Now;
            var Categoriesexists = _context.Categories;

            if (Categoriesexists == null)
            {
                throw new InvalidOperationException("Categories DbSet is null");
            }

            var Category = await Categoriesexists.AnyAsync(c => c.CategoryName == categorydto.CategoryName);
            if (!Category)
            {
                await _context.Set<Category>().AddAsync(result);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"Category already exists");
            }
        }

        public async Task DeleteCategory(int Id)
        {
            var result = await _context.Set<Category>().FindAsync(Id);

            if (result == null)
            {
                throw new KeyNotFoundException($"Category Not Found");
            }

            _context.Set<Category>().Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var result = await _context.Set<Category>()
                .ToListAsync();

            if (result == null)
            {
                throw new KeyNotFoundException($"Category List Empty");
            }
            return result;
        }

        public async Task<Category> GetCategoryById(int Id)
        {
            var result = await _context.Set<Category>().FindAsync(Id);

            if (result == null)
            {
                throw new KeyNotFoundException($"Category Not Found");
            }
            return result;
        }

        public async Task UpdateCategory(Categorydto categorydto, int Id)
        {
            var result = await _context.Set<Category>().FindAsync(Id);
            if (result == null)
            {
                throw new KeyNotFoundException($"Category Not Found");
            }

            _mapper.Map(categorydto, result);
            categorydto.Updated_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            categorydto.Updated_Date = DateTime.Now;
            _context.Set<Category>().Update(result);
            await _context.SaveChangesAsync();

        }
    }
}
