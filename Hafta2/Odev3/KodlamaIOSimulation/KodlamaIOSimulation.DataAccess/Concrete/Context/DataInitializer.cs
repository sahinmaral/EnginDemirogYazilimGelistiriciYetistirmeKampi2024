using KodlamaIOSimulation.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIOSimulation.DataAccess.Concrete.Context;

public static class DataInitializer
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        var instructors = new List<Instructor>
        {
            new Instructor {
                Name = "Engin",
                Surname = "Demiroğ",
                ProfilePhotoPath = "",
                Email = "engin.demirog@hotmail.com",
                Username = "engin.demirog",
                Password = "Abc1234."
             },
            new Instructor {
                Name = "Halit Enes",
                Surname = "Kalaycı",
                ProfilePhotoPath = "",
                Email = "halitenes.kalayci@hotmail.com",
                Username = "halitenes.kalayci",
                Password = "Abc1234."
             },
        };

        var categories = new List<Category>(){
            new Category{
                Name = "Programlama",
            },
        };

        var courses = new List<Course>()
        {
            new Course{
                Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
                CategoryId = categories.First().Id,
            },
            new Course{
                Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                CategoryId = categories.First().Id,
            },
            new Course{
                Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
                CategoryId = categories.First().Id,
            },
            new Course{
                Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
                CategoryId = categories.First().Id,
            },
            new Course{
                Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                CategoryId = categories.First().Id,
            },
            new Course{
                Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",
                CategoryId = categories.First().Id,
            },
            new Course{
                Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                CategoryId = categories.First().Id,
            },
            new Course{
                Name = "Programlamaya Giriş için Temel Kurs",
                CategoryId = categories.First().Id,
            },
        };

        var courseInstructors = new List<CourseInstructor>();

        foreach (var course in courses)
        {
            CourseInstructor courseInstructor = new CourseInstructor
            {
                CourseId = course.Id,
                InstructorId = instructors.First().Id
            };

            courseInstructors.Add(courseInstructor);

            if (course.Name == "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium")
            {
                CourseInstructor courseInstructor2 = new CourseInstructor
                {
                    CourseId = course.Id,
                    InstructorId = instructors.Skip(1).First().Id
                };

                courseInstructors.Add(courseInstructor2);
            }
        }

        modelBuilder.Entity<Instructor>().HasData(instructors);
        modelBuilder.Entity<Category>().HasData(categories);
        modelBuilder.Entity<CourseInstructor>().HasData(courseInstructors);
        modelBuilder.Entity<Course>().HasData(courses);
    }
}