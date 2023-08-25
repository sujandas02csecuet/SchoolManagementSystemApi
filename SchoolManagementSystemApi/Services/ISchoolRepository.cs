using SchoolManagementSystemApi.Migrations;
using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;
using School = SchoolManagementSystemApi.Models.School;

namespace SchoolManagementSystemApi.Services
{
    public interface ISchoolRepository
    {
        string AddSchool(School school);
        string DeleteSchoolByCode(string schoolCode);
        public ICollection<SchoolDto> GetAllSchoolByCode(string schoolCode);
        public ICollection<SchoolDto> GetAllSchoolById(int id);
        public ICollection<SchoolDto> GetAllSchools();
        void Save();
        string UpdateSchool(ModelDto.SchoolDto schoolDtoObj);
    }
}
