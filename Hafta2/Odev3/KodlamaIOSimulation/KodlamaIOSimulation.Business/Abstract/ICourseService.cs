using System.Linq.Expressions;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.Business.Abstract;

public interface ICourseService
{
    IQueryable<Course> GetAll();
    IQueryable<Course> GetWhere(Expression<Func<Course, bool>> expression);
    void Add(Course entity);
}
