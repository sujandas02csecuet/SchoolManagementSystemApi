using SchoolManagementSystemApi.Data;
using SchoolManagementSystemApi.ModelDto;

namespace SchoolManagementSystemApi.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private SchoolManagementApiContext schoolDbContext;

        public EmployeeRepository(SchoolManagementApiContext schoolDbContext = null)
        {
            this.schoolDbContext = schoolDbContext;
        }

        public ICollection<EmployeeDto> GetAllEmployees()
        {
            var listOfEmployees=schoolDbContext.Employees.OrderBy(employee=>employee.Name).ToList();
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
