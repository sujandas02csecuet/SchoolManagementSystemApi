using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystemApi.Controllers
{
  
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {

        [HttpGet]
        public string GetName()
        {

            return "Rama";
        }


        [HttpGet]
        public string GetAddress()
        {
            return "Ayodha";

        }

        [HttpGet]
        public string GetDynasty() {
            return "Surya Bangsa";
        }
    }
}
