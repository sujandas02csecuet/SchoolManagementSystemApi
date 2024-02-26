using Microsoft.EntityFrameworkCore.Diagnostics;
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

        public string DeleteEmployeeById(string id)
        {
            string msg = "Employee Not Found";
            var listOfEmployee = dbContext.Employees.Where(employee => employee.Id == Convert.ToInt32(id)).FirstOrDefault();
            if (listOfEmployee != null)
            { 
            dbContext.Employees.Remove(listOfEmployee);
                Save();
                msg = "success";
            }
            return msg;
        
        }

        private void Save()
        {
            dbContext.SaveChanges();
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
