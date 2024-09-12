using Microsoft.AspNetCore.Mvc;
using io;
namespace hometaskWeb.Controller;


[Route("Students")]
[ApiController]
public class StudentController
{
    private readonly StudentSevice _studentServices = new StudentSevice();

    [HttpPost]
    public bool CreateStudent(Student student)
    {
        return _studentServices.CreateStudent(student);
    }

    [HttpPut]
    public bool UpdateStudent(Student student)
    {
        return _studentServices.UpdateStudent(student);
    }

    [HttpDelete("{id}")]
    public bool DeleteStudent(int id)
    {
        return _studentServices.DeleteStudent(id);
    }

    [HttpGet("{id}")]
    public Student? GetStudentById(int id)
    {
        return _studentServices.GetStudentById(id);
    }

    [HttpGet]
    public IEnumerable<Student> GetAllStudents()
    {
        return _studentServices.GetStudents();
    }
}