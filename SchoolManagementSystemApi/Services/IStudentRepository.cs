using SchoolManagementSystemApi.ModelDto;

namespace SchoolManagementSystemApi.Services
{
    public interface IStudentRepository
    {
        string AddStudent(StudentDto studentDtoObj);
        string DeleteStudentByRollNumber(string rollNumber);
        public ICollection<StudentDto> GetAllStudents();
        public ICollection<StudentDto> GetAllStudentsById(string id);
        public ICollection<StudentDto> GetAllStudentsByName(string name);
        string UpdateStudent(StudentDto studentDtoObj);

           // test from git hub web 1
        // test from git hub web 2
        // test from git hub web 3
    }
}
