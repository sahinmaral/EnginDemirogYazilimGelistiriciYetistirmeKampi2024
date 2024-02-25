using KodlamaIOSimulation.DataAccess.Abstract;
using KodlamaIOSimulation.DataAccess.Concrete.Context;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.DataAccess.Concrete.EntityFramework;

public class CategoryDal : GenericRepository<Category, AppDbContext>, ICategoryDal
{
    public CategoryDal(AppDbContext context) : base(context)
    {
    }
}
