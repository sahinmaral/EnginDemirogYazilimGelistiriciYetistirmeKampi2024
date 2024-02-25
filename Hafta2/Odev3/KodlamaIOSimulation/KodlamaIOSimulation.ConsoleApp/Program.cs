using ConsoleTables;
using KodlamaIOSimulation.Business.Abstract;
using KodlamaIOSimulation.Business.Concrete;
using KodlamaIOSimulation.DataAccess.Abstract;
using KodlamaIOSimulation.DataAccess.Concrete.Context;
using KodlamaIOSimulation.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KodlamaIOSimulation.ConsoleApp;

class Program
{
    private static ICourseService _courseService;
    private static IInstructorService _instructorService;
    private static ICategoryService _categoryService;

    static void Main(string[] args)
    {
        SetServices();

        int choice;

        do
        {
            PrintMenu();

            Console.Write("Seçiminizi yapın (1-4): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out choice) && choice >= 1 && choice <= 4)
            {
                ProcessUserChoice(choice);
            }

        } while (choice != 4);
    }

    static void PrintMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Kodlama.io Simulasyonu");
        Console.WriteLine("Menü");
        Console.WriteLine("1-) Kursları listele");
        Console.WriteLine("2-) Öğretmenleri listele");
        Console.WriteLine("3-) Kategorileri listele");
        Console.WriteLine("4-) Uygulamadan çık");
    }

    static void ProcessUserChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                ListCourses();
                break;
            case 2:
                ListInstructors();
                break;
            case 3:
                ListCategories();
                break;
            case 4:
                Console.WriteLine("Uygulamadan çıkılıyor...");
                break;
            default:
                Console.WriteLine("Geçersiz seçenek.");
                break;
        }
    }

    static void ListCourses()
    {
        var table = new ConsoleTable("#", "Ad", "Kategori Adı");

        var courses = _courseService.GetAll().Include(c => c.Category);

        foreach (var course in courses)
        {
            table.AddRow(course.Id, course.Name, course.Category.Name);
        }

        table.Write();
    }

    static void ListCategories()
    {
        var table = new ConsoleTable("#", "Ad");

        var categories = _categoryService.GetAll();

        foreach (var category in categories)
        {
            table.AddRow(category.Id, category.Name);
        }

        table.Write();
    }

    static void ListInstructors()
    {
        var table = new ConsoleTable("#", "Ad", "Soyad", "Kullanıcı adı", "E-posta");

        var instructors = _instructorService.GetAll();

        foreach (var instructor in instructors)
        {
            table.AddRow(instructor.Id, instructor.Name, instructor.Surname, instructor.Username, instructor.Email);
        }

        table.Write();
    }

    static void SetServices()
    {
        var serviceProvider = new ServiceCollection()
    .AddSingleton<ICourseService, CourseManager>()
    .AddSingleton<ICourseDal, CourseDal>()
    .AddSingleton<IInstructorService, InstructorManager>()
    .AddSingleton<IInstructorDal, InstructorDal>()
    .AddSingleton<ICategoryService, CategoryManager>()
    .AddSingleton<ICategoryDal, CategoryDal>()
    .AddDbContext<AppDbContext>(options =>
    {
        options.UseInMemoryDatabase("InMemoryDatabase");
    })
    .BuildServiceProvider();

        var dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        dbContext.Database.EnsureCreated();

        _courseService = serviceProvider.GetRequiredService<ICourseService>();
        _instructorService = serviceProvider.GetRequiredService<IInstructorService>();
        _categoryService = serviceProvider.GetRequiredService<ICategoryService>();
    }
}
