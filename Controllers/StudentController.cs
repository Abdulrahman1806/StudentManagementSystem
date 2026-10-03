using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
// Allows this controller to use our database context.
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers;

public class StudentsController : Controller
{
    // Represents the connection between this controller and the database.
private readonly ApplicationDbContext _context;

// Dependency Injection gives the controller an ApplicationDbContext automatically.
public StudentsController(ApplicationDbContext context)
{
    _context = context;
}
   /* private static List<Student> students = new List<Student>
    {
        new Student
        {
            Id = 1,
            Name = "Seno",
            Age = 20,
            Department = "Computer Engineering"
        },

        new Student
        {
            Id = 2,
            Name = "zosar",
            Age = 21,
            Department = "AI Engineering"
        },

        new Student
        {
            Id = 3,
            Name = "Omar",
            Age = 22,
            Department = "Computer Science"
        }
    };*/

    // READ:
// Gets all students from the MySQL database
// through Entity Framework Core and sends them to the Index View.
public IActionResult Index()
{
    var students = _context.Students.ToList();

    return View(students);
}

// UPDATE - GET
// Gets the student from the database using the ID
// and sends the student data to the Edit page.
public IActionResult Edit(int id)
{
    var student = _context.Students.Find(id);

    return View(student);
}


// UPDATE - POST
// Receives the edited student data from the form
// and saves the changes to the database.
[HttpPost]
public IActionResult Edit(Student student)
{
    _context.Students.Update(student);
    _context.SaveChanges();

    return RedirectToAction("Index");
}

// DELETE
public IActionResult Delete(int id)
{
    var student = _context.Students.Find(id);

    return View(student);
}
[HttpPost]
public IActionResult Delete(Student student)
{
    _context.Students.Remove(student);
    _context.SaveChanges();

    return RedirectToAction("Index");
}

    public IActionResult Create()
    {
        return View();
    }


   [HttpPost]
public IActionResult Create(Student student)
{
    _context.Students.Add(student);
    _context.SaveChanges();

    return RedirectToAction("Index");
}
}
