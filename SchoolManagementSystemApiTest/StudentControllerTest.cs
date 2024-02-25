using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystemApi.Controllers;
using SchoolManagementSystemApi.Data;
using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;
using SchoolManagementSystemApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace SchoolManagementSystemApiTest
{
    public class StudentControllerTest
    {
        private StudentController studentController;
        private IStudentRepository studentRepository;

        public static DbContextOptions<SchoolManagementApiContext> dbContextOptions { get; }
        public static string connectionString = "Data Source=SUJANHOME;Database=SchoolManagementSystem;User ID=sa;Password=12345678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

        static StudentControllerTest()
        {
            dbContextOptions = new DbContextOptionsBuilder<SchoolManagementApiContext>().UseSqlServer(connectionString).Options;
        }
        public StudentControllerTest()

        {
            var context = new SchoolManagementApiContext(dbContextOptions);
            studentRepository = new StudentRepository(context);
        }

        [Fact]
        public async void Task_GetStudentById_Return_OkResult()
        {
            //Arrange
            var controller = new StudentController(studentRepository);
            var id = 3;

            var data = controller.GetAllStudentsById(id.ToString());
            Assert.IsType<OkObjectResult>(data);

        }

        [Fact]
        public async void Task_Add_ValidData_Return_OkResult()
        { 
        var controller= new StudentController(studentRepository);

            var studentDto = new StudentDto()
            {
                Name = "test",
                PresentAddress = "test",
                RollNumber = "BB196",
                ContactNo = "24234234"
            };

            var data = controller.AddStudent(studentDto);
            Assert.IsType<OkObjectResult>(data);
        }




       

        [Fact]
        public async void Task_Delete_Student_Return_NotFoundResult()
        { 
        var controller=new StudentController(studentRepository);
            var rolll = "BB194";

            var data=controller.DeleteStudentByRoll(rolll.ToString());

            var okResult = Assert.IsType<OkObjectResult>(data);
            Assert.Equal("success", okResult.Value);

          
          
        }

        [Fact]
        public void DeleteStudentByRoll_ReturnsNotFoundResult_WhenStudentNotFound()
        {
            var controller = new StudentController(studentRepository);
            var roll = "BB194";

            // Act
            var result = controller.DeleteStudentByRoll(roll);

            // Assert
            var notFoundResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Student not found", notFoundResult.Value);
        }


    }
}
