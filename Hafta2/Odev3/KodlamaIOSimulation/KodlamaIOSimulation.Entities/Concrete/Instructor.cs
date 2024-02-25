using KodlamaIOSimulation.Entities.Abstract;

namespace KodlamaIOSimulation.Entities.Concrete;

public class Instructor : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string ProfilePhotoPath { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public List<CourseInstructor> CourseInstructors { get; set; }
}

