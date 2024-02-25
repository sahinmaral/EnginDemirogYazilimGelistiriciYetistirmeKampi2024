using KodlamaIOSimulation.DataAccess.Abstract;
using KodlamaIOSimulation.DataAccess.Concrete.Context;
using KodlamaIOSimulation.Entities.Concrete;

namespace KodlamaIOSimulation.DataAccess.Concrete.EntityFramework;

public class CourseDal : GenericRepository<Course, AppDbContext>, ICourseDal
{
    public CourseDal(AppDbContext context) : base(context)
    {
    }
}
