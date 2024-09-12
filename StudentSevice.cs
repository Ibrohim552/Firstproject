namespace  io;

using Dapper;
using Npgsql;

public class StudentSevice:IStudentServices
{
    public bool CreateStudent(Student student)
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connectionString))
            {
                connection.Open();
                return connection.Execute(SqlCommand.addSudent, student)>0;
            }

        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public bool UpdateStudent(Student student)
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connectionString))
            {
                connection.Open();
                return connection.Execute(SqlCommand.updateStudent,student)>0;
            }

        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public bool DeleteStudent(int id )
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connectionString))
            {
                connection.Open();
                return connection.Execute(SqlCommand.deleteStudent, new {Id=id})>0;
            }

        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public Student? GetStudentById(int id)
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<Student>(SqlCommand.getStudentById,new {Id=id});
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Student> GetStudents()
    {
        try
        {
            using (NpgsqlConnection connection = new(SqlCommand.connectionString))
            {
                connection.Open();
                return connection.Query<Student>(SqlCommand.getAllStudents);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}