using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.DAL;

public interface IStudentRepository <T> where T : class
{
    IEnumerable<T> GetStudents(Func<T, bool>? predicate = null);
    T GetStudentByID(int studentId);
    void InsertStudent(T student);
    void DeleteStudent(int studentID);
    void UpdateStudent(T student);
    void Save();
}
