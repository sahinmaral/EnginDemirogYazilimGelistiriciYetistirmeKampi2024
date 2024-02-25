using KodlamaIOSimulation.Entities.Abstract;

namespace KodlamaIOSimulation.Entities.Concrete;

public class Category : BaseEntity
{
    public string Name { get; set; } = null!;
    public List<Course> Courses { get; set; }
}

