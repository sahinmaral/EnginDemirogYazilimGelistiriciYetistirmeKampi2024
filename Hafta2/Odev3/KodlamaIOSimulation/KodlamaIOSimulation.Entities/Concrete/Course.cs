using KodlamaIOSimulation.Entities.Abstract;

namespace KodlamaIOSimulation.Entities.Concrete;

public class Course : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    public Category Category { get; set; } = null!;
    public string CategoryId { get; set; } = null!;

    public List<CourseInstructor> CourseInstructors { get; set; }
}
