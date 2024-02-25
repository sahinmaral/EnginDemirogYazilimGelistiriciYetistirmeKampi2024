using System.Linq.Expressions;
using KodlamaIOSimulation.Business.Abstract;
using KodlamaIOSimulation.DataAccess.Abstract;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.Business.Concrete;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _InstructorDal;

    public InstructorManager(IInstructorDal InstructorDal)
    {
        _InstructorDal = InstructorDal;
    }

    public void Add(Instructor entity)
    {
        _InstructorDal.Add(entity);
    }

    public IQueryable<Instructor> GetAll()
    {
        return _InstructorDal.GetAll();
    }

    public IQueryable<Instructor> GetWhere(Expression<Func<Instructor, bool>> expression)
    {
        return _InstructorDal.GetWhere(expression);
    }
}