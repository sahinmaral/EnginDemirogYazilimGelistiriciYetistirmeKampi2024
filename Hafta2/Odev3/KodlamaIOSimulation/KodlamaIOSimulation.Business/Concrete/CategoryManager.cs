using System.Linq.Expressions;
using KodlamaIOSimulation.Business.Abstract;
using KodlamaIOSimulation.DataAccess.Abstract;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _CategoryDal;

    public CategoryManager(ICategoryDal CategoryDal)
    {
        _CategoryDal = CategoryDal;
    }

    public void Add(Category entity)
    {
        _CategoryDal.Add(entity);
    }

    public IQueryable<Category> GetAll()
    {
        return _CategoryDal.GetAll();
    }

    public IQueryable<Category> GetWhere(Expression<Func<Category, bool>> expression)
    {
        return _CategoryDal.GetWhere(expression);
    }
}