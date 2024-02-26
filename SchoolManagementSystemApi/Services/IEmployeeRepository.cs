using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;

namespace SchoolManagementSystemApi.Services
{
    public interface IEmployeeRepository
    {
        string DeleteEmployeeById(string id);
        public List<EmployeeDto> GetAllEmployees();
        public ICollection<EmployeeDto> GetAllEmployeesByType(string employeeType);
    }
}
