using SchoolManagementSystemApi.Migrations;
using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;
using School = SchoolManagementSystemApi.Models.School;

namespace SchoolManagementSystemApi.Services
{
    public interface ISchoolRepository
    {
        string AddSchool(ModelDto.SchoolDto schoolDtoObj);
        string DeleteSchoolByCode(string code);
        public ICollection<SchoolDto> GetAllSchoolByCode(string schoolCode);
        public ICollection<SchoolDto> GetAllSchoolById(int id);
        public ICollection<SchoolDto> GetAllSchools();
        void Save();
        string UpdateSchool(ModelDto.SchoolDto schoolDtoObj);

           // test from git hub web 1
        // test from git hub web 2
        // test from git hub web 3
    }
}
