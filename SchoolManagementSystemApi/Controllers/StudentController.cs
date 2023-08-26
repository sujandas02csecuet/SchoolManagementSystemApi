using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystemApi.Services;

namespace SchoolManagementSystemApi.Controllers
{
  
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {

        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var studentList = studentRepository.GetAllStudents().ToList();
            return Ok(studentList);
           
        }


        [HttpGet]
        public IActionResult GetStudentByName(string name)
        {

            var studentList=studentRepository.GetAllStudentsByName(name).ToList();
            return Ok(studentList);

        }


        [HttpPost]
        public IActionResult DeleteStudent(string rollNumber) 
        {
            string msg = studentRepository.DeleteStudentByRollNumber(rollNumber);
            return Ok(msg);
        
        }

    }
}
