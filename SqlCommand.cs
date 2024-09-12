public class SqlCommand
{
    public const string connectionString = "Server=localhost;Port=5432;Database=web_db;User Id=postgres;Password=postgres;";
    public const string addSudent = "INSERT INTO students (age,firstname,lastname) VALUES (@Age,@FirstName,@LastName)";
    public const string updateStudent = "UPDATE students SET age=@Age firstname = @FirstName,lastname=@LastName WHERE id = @id";
    public const string deleteStudent = "DELETE FROM students WHERE id = @id";
    public const string getStudentById = "SELECT * FROM students WHERE id = @id";
    public const string getAllStudents = "SELECT * FROM students";
}