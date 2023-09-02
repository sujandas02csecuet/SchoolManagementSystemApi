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

        // joy sree rama

    }
}
