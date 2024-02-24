using SchoolManagementSystemApi.Data;
using SchoolManagementSystemApi.ModelDto;

namespace SchoolManagementSystemApi.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private SchoolManagementApiContext dbContext;

        public EmployeeRepository(SchoolManagementApiContext schoolDbContext = null)
        {
            dbContext = schoolDbContext;
        }

        public List<EmployeeDto> GetAllEmployees()
        {
            var listOfEmployees=dbContext.Employees.OrderBy(employee=>employee.Name).ToList();
            List<EmployeeDto> employees = new List<EmployeeDto>();


            foreach (var employee in listOfEmployees)
            {

                employees.Add(new EmployeeDto()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    PresentAddress = employee.PresentAddress,
                    EmployeeType = employee.EmployeeType,
                    NationalIdNo = employee.NationalIdNo,
                });
            }
            return employees;
        }

        public ICollection<EmployeeDto> GetAllEmployeesByType(string employeeType)
        {
            var listOfEmployees = dbContext.Employees.Where(employee=>employee.EmployeeType.Contains(employeeType)).ToList();
        List<EmployeeDto> employees = new List<EmployeeDto>();

            foreach (var employee in listOfEmployees)
            {

                employees.Add(new EmployeeDto()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    PresentAddress = employee.PresentAddress,
                    EmployeeType = employee.EmployeeType,
                    NationalIdNo = employee.NationalIdNo,
                });
            }
            return employees;
        }
    }
}
