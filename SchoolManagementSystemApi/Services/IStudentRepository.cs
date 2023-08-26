using SchoolManagementSystemApi.ModelDto;

namespace SchoolManagementSystemApi.Services
{
    public interface IStudentRepository
    {
        string DeleteStudentByRollNumber(string rollNumber);
        public ICollection<StudentDto> GetAllStudents();
        public ICollection<StudentDto> GetAllStudentsByName(string name);
    }
}
