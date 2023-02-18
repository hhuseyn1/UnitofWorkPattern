using UnitofWorkPattern.DAL.Contexts;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.DAL;

public class UnitOfWork : IDisposable
{
    private readonly AppDbContext context;
    private StudentRepository<Author> authorRepository;
    private StudentRepository<Book> bookRepository;
    private StudentRepository<Category> categoryRepository;
    private StudentRepository<Department> departmentRepository;
    private StudentRepository<Faculty> facultyRepository;
    private StudentRepository<Group> groupRepository;
    private StudentRepository<Lib> libRepository;
    private StudentRepository<Press> pressRepository;
    private StudentRepository<S_Card> s_CardRepository;
    private StudentRepository<Student> studentRepository;
    private StudentRepository<T_Card> t_CardRepository;
    private StudentRepository<Teacher> teacherRepository;
    private StudentRepository<Theme> themeRepository;

    public StudentRepository<Theme> ThemeRepository
    {
        get
        {
            if (themeRepository == null)
                themeRepository = new StudentRepository<Theme>(context);

            return themeRepository;
        }
    }


    public StudentRepository<Teacher> TeacherRepository
    {
        get
        {
            if (teacherRepository == null)
                teacherRepository = new StudentRepository<Teacher>(context);

            return teacherRepository;
        }
    }


    public StudentRepository<T_Card> T_CardRepository
    {
        get
        {
            if (t_CardRepository == null)
                t_CardRepository = new StudentRepository<T_Card>(context);

            return t_CardRepository;
        }
    }


    public StudentRepository<Student> StudentRepository
    {
        get
        {
            if (studentRepository == null)
                studentRepository = new StudentRepository<Student>(context);

            return studentRepository;
        }
    }


    public StudentRepository<S_Card> S_CardRepository
    {
        get
        {
            if (s_CardRepository == null)
                s_CardRepository = new StudentRepository<S_Card>(context);

            return s_CardRepository;
        }
    }


    public StudentRepository<Press> PressRepository
    {
        get
        {
            if (pressRepository == null)
                pressRepository = new StudentRepository<Press>(context);

            return pressRepository;
        }
    }


    public StudentRepository<Lib> LibRepository
    {
        get
        {
            if (libRepository == null)
                libRepository = new StudentRepository<Lib>(context);

            return libRepository;
        }
    }


    public StudentRepository<Group> GroupRepository
    {
        get
        {
            if (groupRepository == null)
                groupRepository = new StudentRepository<Group>(context);

            return groupRepository;
        }
    }


    public StudentRepository<Faculty> RacultyRepository
    {
        get
        {
            if (facultyRepository == null)
                facultyRepository = new StudentRepository<Faculty>(context);

            return facultyRepository;
        }
    }


    public StudentRepository<Department> DepartmentRepository
    {
        get
        {
            if (departmentRepository == null)
                departmentRepository = new StudentRepository<Department>(context);

            return departmentRepository;
        }
    }

    public StudentRepository<Category> CategoryRepository
    {
        get
        {
            if (categoryRepository == null)
                categoryRepository = new StudentRepository<Category>(context);

            return categoryRepository;
        }
    }

    public StudentRepository<Book> BookRepository
    {
        get
        {
            if (bookRepository == null)
                bookRepository = new StudentRepository<Book>(context);

            return bookRepository;
        }
    }

    public StudentRepository<Author> AuthorRepository
    {
        get
        {
            if (authorRepository == null)
                authorRepository = new StudentRepository<Author>(context);

            return authorRepository;
        }
    }


    public UnitOfWork()
    {
        context = new();
    }

    public void Save() => context.SaveChanges();
    public async void SaveAsync() => await context.SaveChangesAsync();
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
}