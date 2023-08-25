using SchoolManagementSystemApi.Data;
using SchoolManagementSystemApi.Migrations;
using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;
using School = SchoolManagementSystemApi.Models.School;

namespace SchoolManagementSystemApi.Services
{
    public class SchoolRepository : ISchoolRepository
    {

        private SchoolManagementApiContext _context;

        public SchoolRepository(SchoolManagementApiContext context)
        {
            _context = context;
        }

        public string AddSchool(School school)
        {
          
            _context.Add(school);
            Save();
             
            return "success";
        }

        public string DeleteSchoolByCode(string schoolCode)
        {
            string msg = "";
            var listOfSchool = _context.Schools.Where(s => s.Code == schoolCode).FirstOrDefault();

            if (listOfSchool != null)
            {
                _context.Schools.Remove(listOfSchool);
                Save();
                msg = "success";

            }
            return msg;
        }

        public ICollection<SchoolDto> GetAllSchoolByCode(string schoolCode)
        {
            var listOfSchool = _context.Schools.Where(s => s.Code == schoolCode).ToList();
            List<SchoolDto> schoolsFromDb = new List<SchoolDto>();

            foreach (var schoolData in listOfSchool)
            {
                schoolsFromDb.Add(new SchoolDto()
                {
                    Id = schoolData.Id,
                    Name = schoolData.Name,
                    SchoolAddress = schoolData.SchoolAddress,
                    MediumOfTeaching = schoolData.MediumOfTeaching,
                    Code = schoolData.Code,
                });
            }

            return schoolsFromDb;
        }

        public ICollection<SchoolDto> GetAllSchoolById(int id)
        {
            var listOfSchool = _context.Schools.Where(s => s.Id == id).ToList();
            List<SchoolDto> schoolsFromDb = new List<SchoolDto>();

            foreach (var schoolData in listOfSchool)
            {
                schoolsFromDb.Add(new SchoolDto()
                {
                    Id = schoolData.Id,
                    Name = schoolData.Name,
                    SchoolAddress = schoolData.SchoolAddress,
                    MediumOfTeaching = schoolData.MediumOfTeaching,
                    Code = schoolData.Code,
                });
            }

            return schoolsFromDb;
        }

        public ICollection<SchoolDto> GetAllSchools()
        {
            var listOfSchool = _context.Schools.OrderBy(s => s.Name).ToList();
            List<SchoolDto> schoolsFromDb = new List<SchoolDto>();

            foreach (var schoolData in listOfSchool)
            {
                schoolsFromDb.Add(new SchoolDto()
                {
                    Id = schoolData.Id,
                    Name = schoolData.Name,
                    SchoolAddress = schoolData.SchoolAddress,
                    MediumOfTeaching = schoolData.MediumOfTeaching,
                    Code= schoolData.Code,
                });
            }

            return schoolsFromDb;


        }

        public void Save()
        {
          _context.SaveChanges();
        
        }

        public string UpdateSchool(SchoolDto schoolDto)
        {
            
            try
            {
                Models.School schoolObj = new Models.School();
                schoolObj.Id = schoolDto.Id;
                schoolObj.Name = schoolDto.Name;
                schoolObj.SchoolAddress = schoolDto.SchoolAddress;
                schoolObj.MediumOfTeaching = schoolDto.MediumOfTeaching;
                schoolObj.Code = schoolDto.Code;


                _context.Entry(schoolObj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                 Save();


                return "success";
            }
            catch (Exception exp)
            {

                return exp.Message.ToString();
            }

           
        }
    }
}
