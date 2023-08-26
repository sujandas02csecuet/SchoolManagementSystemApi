using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystemApi.Services;

namespace SchoolManagementSystemApi.Controllers
{
  
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository iStudentRepository;


        public StudentController(IStudentRepository iStudentRepository)
        {
            this.iStudentRepository = iStudentRepository;
        }


        [HttpGet]
        public IActionResult ConflictTesting() {

            string msg = "joy sree Ram";
            return Ok(msg);

        }
       


        
    }
}
