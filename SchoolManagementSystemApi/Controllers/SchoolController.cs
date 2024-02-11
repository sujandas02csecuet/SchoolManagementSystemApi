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

      
        [HttpGet]
        public async Task< IActionResult> GetAllSchools()
        {

            var schoolList = iSchoolRepository.GetAllSchools().ToList();

            return Ok(schoolList);

        }

        [HttpGet]
        public async Task<IActionResult> GetSchoolByCode(string schoolCode)
        {

            var school = iSchoolRepository.GetAllSchoolByCode(schoolCode);

            return Ok(school);

        }


        [HttpGet]
        public async Task<IActionResult> GetSchooById(int id)
        {
            var school = iSchoolRepository.GetAllSchoolById(id);

            return Ok(school);
        }

      // [HttpPost]
        [HttpDelete("{code}")]
        //[HttpDelete]

        public async  Task<IActionResult> DeleteSchoolByCode(string code)
        {
            string msg = iSchoolRepository.DeleteSchoolByCode(code);
           
            return Ok(msg);
          //  return Ok(new { message = "User deleted" });
        }

        [HttpPost]
       public async Task<IActionResult> AddSchool([FromBody] ModelDto.SchoolDto schoolDtoObj)
       
        {
            string msg = iSchoolRepository.AddSchool(schoolDtoObj);
            
            return Ok(msg);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSchool([FromBody] ModelDto.SchoolDto schoolDtoObj)
       {
                string msg = iSchoolRepository.UpdateSchool(schoolDtoObj);
                return Ok(msg);
        }

        // test from git hub web 1
        // test from git hub web 2
        // test from git hub web 3
        
    }
}
