using System.Linq.Expressions;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.Business.Abstract;

public interface IInstructorService
{
    IQueryable<Instructor> GetAll();
    IQueryable<Instructor> GetWhere(Expression<Func<Instructor, bool>> expression);
    void Add(Instructor entity);
}
