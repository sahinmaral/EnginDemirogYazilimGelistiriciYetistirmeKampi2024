namespace KodlamaIOSimulation.Entities.Concrete;

public class CourseInstructor
{
    public Course Course { get; set; } = null!;
    public string CourseId { get; set; } = null!;
    public Instructor Instructor { get; set; } = null!;
    public string InstructorId { get; set; } = null!;
}
