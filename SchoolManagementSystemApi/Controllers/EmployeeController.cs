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

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployeeById(string id)
        {
            string msg = iEmployeeRepository.DeleteEmployeeById(id);

            return Ok(msg);
        }
        // ram dut adulito baldhama


        [HttpGet]
        public IActionResult GetEmployeeByType(string employeeType) {
        
            var employeeList=iEmployeeRepository.GetAllEmployeesByType(employeeType).ToList();
            return Ok(employeeList);

        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] ModelDto.EmployeeDto employeeObj)
        {
            string msg = iEmployeeRepository.AddEmployee(employeeObj);
            return Ok(msg);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(string id)
        {
            var  employee = iEmployeeRepository.GetEmployeeById(Convert.ToInt32(id));

            return Ok(employee);
        }

    }
}
