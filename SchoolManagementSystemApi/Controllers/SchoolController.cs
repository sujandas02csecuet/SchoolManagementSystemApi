using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystemApi.Migrations;
using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;
using SchoolManagementSystemApi.Services;


namespace SchoolManagementSystemApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepository iSchoolRepository;


        public SchoolController(ISchoolRepository iSchoolRepository)
        {
                this.iSchoolRepository = iSchoolRepository;
        }

        [EnableCors("Policy1")]
        [HttpGet]
        public IActionResult GetAllSchools()
        {

            var schoolList = iSchoolRepository.GetAllSchools().ToList();

            return Ok(schoolList);

        }

        [HttpGet]
        public IActionResult GetSchoolByCode(string schoolCode)
        {

            var school = iSchoolRepository.GetAllSchoolByCode(schoolCode);

            return Ok(school);

        }


        [HttpGet]
        public IActionResult GetSchooById(int id)
        {
            var school = iSchoolRepository.GetAllSchoolById(id);

            return Ok(school);
        }

        [HttpPost]
        public IActionResult DeleteSchoolByCode(string schoolCode)
        {
            string msg = iSchoolRepository.DeleteSchoolByCode(schoolCode);
           
            return Ok(msg);
        }

        [HttpPost]
       public IActionResult AddSchool([FromBody] ModelDto.SchoolDto schoolDtoObj)
       
        {
            string msg = iSchoolRepository.AddSchool(schoolDtoObj);
            
            return Ok(msg);
        }

        [HttpPost]
        public IActionResult UpdateSchool([FromBody] ModelDto.SchoolDto schoolDtoObj)
       {
                string msg = iSchoolRepository.UpdateSchool(schoolDtoObj);
                return Ok(msg);
        }

        // test from git hub web 1
        // test from git hub web 2
        // test from git hub web 3
        
    }
}
