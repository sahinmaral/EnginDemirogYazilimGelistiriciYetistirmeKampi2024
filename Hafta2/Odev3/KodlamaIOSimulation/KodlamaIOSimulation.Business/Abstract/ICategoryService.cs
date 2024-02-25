using System.Linq.Expressions;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.Business.Abstract;

public interface ICategoryService
{
    IQueryable<Category> GetAll();
    IQueryable<Category> GetWhere(Expression<Func<Category, bool>> expression);
    void Add(Category entity);
}