using UnitofWorkPattern.DAL;
using UnitofWorkPattern.DAL.Contexts;
using UnitofWorkPattern.Models;
namespace Main;
class Program
{
    static void Main()
    {
        AppDbContext context = new AppDbContext();
        StudentRepository work = new StudentRepository(context);

        var student = new Student()
        {
            FirstName = "Huseyn",
            LastName = "Hemidov",
            Id_Group= 1
        };

        work.InsertStudent(student);
        work.Save();
    }
}
