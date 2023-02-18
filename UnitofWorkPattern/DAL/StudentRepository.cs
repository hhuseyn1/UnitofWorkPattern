using Microsoft.EntityFrameworkCore;
using System;
using UnitofWorkPattern.DAL.Contexts;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.DAL;

public class StudentRepository<T> : IStudentRepository<T> where T : BaseEntity
{
    private AppDbContext context;
    private readonly DbSet<T> dbSet;

    public StudentRepository(AppDbContext context)
    {
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        dbSet = context.Set<T>();
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

    public T GetStudentByID(int studentId) =>  dbSet.Find(studentId);
    public IEnumerable<T> GetStudents(Func<T, bool>? predicate = null) => predicate is null ? dbSet.ToList() : dbSet.Where(predicate).ToList();
    public void InsertStudent(Student student) => context.Students.Add(student);

    public void Save() => context.SaveChanges();


    public void InsertStudent(T student) => dbSet.Add(student);

    public void UpdateStudent(T student) => dbSet.Update(student);

}
