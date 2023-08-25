using SchoolManagementSystemApi.ModelDto;

namespace SchoolManagementSystemApi.Services
{
    public interface IStudentRepository
    {
        public ICollection<StudentDto> GetAllStudents();
    }
}
