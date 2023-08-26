using Microsoft.EntityFrameworkCore;
using SchoolManagementSystemApi.Data;
using SchoolManagementSystemApi.ModelDto;

namespace SchoolManagementSystemApi.Services
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolManagementApiContext dbContext;

        public StudentRepository(SchoolManagementApiContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public string DeleteStudentByRollNumber(string rollNumber)
        {
            string msg = "";
            var listOfStudent = dbContext.Students.Where(student => student.RollNumber == rollNumber).FirstOrDefault();

            if (listOfStudent != null)
            {
                dbContext.Students.Remove(listOfStudent);
                Save();
                msg = "success";

            }
            return msg;
        }

        private void Save()
        {
            dbContext.SaveChanges();
        }

        public ICollection<StudentDto> GetAllStudents()
        {
            var listOfStudent=dbContext.Students.OrderBy(student => student.Name).ToList();
            List<StudentDto> students = new List<StudentDto>();
            foreach (var student in listOfStudent)
            {

                students.Add(new StudentDto()
                {
                    Id = student.Id,
                    Name = student.Name,
                    ContactNo = student.ContactNo,
                    PresentAddress = student.PresentAddress,
                    RollNumber = student.RollNumber,

                });
            }
            return students;
        }

        public ICollection<StudentDto> GetAllStudentsByName(string name)
        {
           var listOfStudent=dbContext.Students.Where(student=>student.Name.Contains(name)).ToList();
            List<StudentDto> students=new List<StudentDto>();

            foreach (var student in listOfStudent)
            {

                students.Add(new StudentDto()
                {
                    Id = student.Id,
                    Name = student.Name,
                    ContactNo = student.ContactNo,
                    PresentAddress = student.PresentAddress,
                    RollNumber = student.RollNumber,
                });
            }
            return students;
        }

        public string AddStudent(StudentDto studentDtoObj)
        {
            try
            {


                Models.Student studentObj = new Models.Student();
              
                studentObj.Name = studentDtoObj.Name;
                studentObj.PresentAddress = studentDtoObj.PresentAddress;
                studentObj.RollNumber = studentDtoObj.RollNumber;
                studentObj.ContactNo = studentDtoObj.ContactNo;
                dbContext.Add(studentObj);
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
