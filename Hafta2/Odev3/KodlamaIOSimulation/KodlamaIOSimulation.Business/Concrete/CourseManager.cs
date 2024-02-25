using System.Linq.Expressions;
using KodlamaIOSimulation.Business.Abstract;
using KodlamaIOSimulation.DataAccess.Abstract;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course entity)
    {
        _courseDal.Add(entity);
    }

    public IQueryable<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public IQueryable<Course> GetWhere(Expression<Func<Course, bool>> expression)
    {
        return _courseDal.GetWhere(expression);
    }
}
