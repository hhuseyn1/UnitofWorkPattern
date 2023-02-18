using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.DAL.Contexts;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.DAL;

public class StudentRepository : IStudentRepository
{
    private AppDbContext context;

    public StudentRepository(AppDbContext context)
    {
        this.context = context;
    }

    public void DeleteStudent(int studentID)
    {
        Student student = context.Students.Find(studentID);
        context.Students.Remove(student);
    }
    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public Student GetStudentByID(int studentId) => context.Students.Find(studentId);

    public IEnumerable<Student> GetStudents() => context.Students.ToList();

    public void InsertStudent(Student student) => context.Students.Add(student);

    public void Save() => context.SaveChanges();

    public void UpdateStudent(Student student) => context.Entry(student).State = EntityState.Modified;

}
