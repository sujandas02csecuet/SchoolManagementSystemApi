using SchoolManagementSystemApi.Data;
using SchoolManagementSystemApi.ModelDto;

namespace SchoolManagementSystemApi.Services
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolManagementApiContext dbContext;

        public StudentRepository(SchoolManagementApiContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ICollection<StudentDto> GetAllStudents()
        {
            var listOfStudent=dbContext.Students.OrderBy(student => student.Name).ToList();
            List<StudentDto> students = new List<StudentDto>();
            foreach (var student in listOfStudent)
            {

                students.Add(new StudentDto()
                {
                    Id = student.Id,
                    Name = student.Name,
                    ContactNo = student.ContactNo,
                    PresentAddress = student.PresentAddress,
                    RollNumber = student.RollNumber,

                });
            }
            return students;
        }
    }
}
