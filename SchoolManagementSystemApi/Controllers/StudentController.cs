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
        public IActionResult GetAllStudents()
        {

            var studentList = iStudentRepository.GetAllStudents().ToList();

            return Ok(studentList);

        }
        [HttpGet]
        public IActionResult GetAllStudentsByName(string name)
        {

            var studentList = iStudentRepository.GetAllStudentsByName(name).ToList();

            return Ok(studentList);

        }


        [HttpPost]
        public IActionResult DeleteStudentByRoll(string rollNumber)
        {
            string msg = iStudentRepository.DeleteStudentByRollNumber(rollNumber);

            return Ok(msg);
        }


        [HttpPost]
        public IActionResult AddStudent([FromBody] ModelDto.StudentDto studentDtoObj)

        {
            string msg = iStudentRepository.AddStudent(studentDtoObj);

            return Ok(msg);
        }

        [HttpPost]
        public IActionResult UpdateStudent([FromBody] ModelDto.StudentDto studentDtoObj)
        {
            string msg = iStudentRepository.UpdateStudent(studentDtoObj);
            return Ok(msg);
        }


        [HttpGet]
        public IActionResult GetAllStudentsById(string id)
        {
            var studentList = iStudentRepository.GetAllStudentsById(id).ToList();

            return Ok(studentList);

        }

        ////////////////
        /////////////////////
        /////////////////////////////////
    }
}
