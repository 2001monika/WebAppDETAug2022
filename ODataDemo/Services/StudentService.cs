using ODataDemo.Models;

namespace ODataDemo.Services
{
    public class StudentService : IStudentService
    {
        public IQueryable<Student> RetrieveAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name="moni g",
                    Score=200
                },

                new Student
                {
                    Id = Guid.NewGuid(),
                    Name="priya",
                    Score=120
                },

                new Student
                {
                    Id = Guid.NewGuid(),
                    Name="anny",
                    Score=170
                }
            }.AsQueryable(); ;
        }
    }
}
