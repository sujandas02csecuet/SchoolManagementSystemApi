using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystemApi.Services;

namespace SchoolManagementSystemApi.Controllers
{
   
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository iEmployeeRepository;


        public EmployeeController(IEmployeeRepository iEmployeeRepository )
        {
            this.iEmployeeRepository = iEmployeeRepository;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employeeList = iEmployeeRepository.GetAllEmployees().ToList();
            return Ok(employeeList);
        }
// ram dut adulito baldhama
        

        [HttpGet]
        public IActionResult GetEmployeeByType(string employeeType) {
        
            var employeeList=iEmployeeRepository.GetAllEmployeesByType(employeeType).ToList();
            return Ok(employeeList);

        }







    }
}
