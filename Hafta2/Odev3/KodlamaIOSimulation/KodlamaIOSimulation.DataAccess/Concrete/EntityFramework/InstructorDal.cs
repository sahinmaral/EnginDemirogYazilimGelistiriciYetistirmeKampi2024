using KodlamaIOSimulation.DataAccess.Abstract;
using KodlamaIOSimulation.DataAccess.Concrete.Context;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.DataAccess.Concrete.EntityFramework;

public class InstructorDal : GenericRepository<Instructor, AppDbContext>, IInstructorDal
{
    public InstructorDal(AppDbContext context) : base(context)
    {
    }
}