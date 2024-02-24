using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;

namespace SchoolManagementSystemApi.Services
{
    public interface IEmployeeRepository
    {
        public List<EmployeeDto> GetAllEmployees();
        public ICollection<EmployeeDto> GetAllEmployeesByType(string employeeType);
    }
}
