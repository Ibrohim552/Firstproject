public interface IStudentServices
{
    bool CreateStudent(Student student);
    bool UpdateStudent(Student student);
    bool DeleteStudent(int id);
    Student? GetStudentById(int id);
    IEnumerable<Student> GetStudents();
}