using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Domain.Entities;
using TestSolution.Domain.Repositories;
using TestSolution.Infra.Data;

namespace TestSolution.Infra.Repositories
{
    public class CategoryRepository(DataContext dataContext) : ICategoryRepository
    {
        private readonly DataContext _dataContext = dataContext;
        public Task<Category> CategGetById(Guid id)
        {
            return _dataContext.Categories.FirstOrDefault(x => x.Id == id);
        }

        public Task<IEnumerable<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }
    }
}
