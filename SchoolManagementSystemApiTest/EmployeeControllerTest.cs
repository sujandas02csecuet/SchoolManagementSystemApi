using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Moq;
using SchoolManagementSystemApi.Controllers;
using SchoolManagementSystemApi.Data;
using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;
using SchoolManagementSystemApi.Services;

namespace SchoolManagementSystemApiTest;

public class EmployeeControllerTest


    
{
    private EmployeeController employeeController;
    private IEmployeeRepository employeeRepository;

    public static DbContextOptions<SchoolManagementApiContext> dbContextOptions { get; }
    public static string connectionString = "Data Source=SUJANHOME;Database=SchoolManagementSystem;User ID=sa;Password=12345678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

    static EmployeeControllerTest()
    {
        dbContextOptions = new DbContextOptionsBuilder<SchoolManagementApiContext>().UseSqlServer(connectionString).Options;
    }
    public EmployeeControllerTest( )
        
    {
        var context =new SchoolManagementApiContext(dbContextOptions);
        employeeRepository=new EmployeeRepository(context);
     
    }


    [Fact]
    public async void Task_GetAllEmployee_Return_OkResult()
    {

        var controller = new EmployeeController(employeeRepository);

        var data =  controller.GetAllEmployees();

        Assert.IsType<OkObjectResult>(data);


    }

    [Fact]
    public void Task_GetPosts_Return_BadRequestResut() {

        var controller = new EmployeeController(employeeRepository);

        var data = controller.GetAllEmployees();

        data = null;

        if (data != null)
        {
            Assert.IsType<BadRequestResult>(data);
        }
    }

    //[Fact]
    //public async void Task_GetPosts_MatchResult() { 
    
    //    var controller=new EmployeeController(employeeRepository);
    //    var data = controller.GetAllEmployees();
    //    Assert.IsType<OkObjectResult>(data);

    //    var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
        
    //    var post=okResult.Value.Should().BeAssignableTo<List<EmployeeDto>>().Subject;

    //    Assert.Equal("", post[0].Name);

    //}

    
    [Fact]
    public void GetAll_Employee_Success()
    {
        // Arrange

        var employeeController = new EmployeeController(employeeRepository);

        //Act
        var result = employeeController.GetAllEmployees();
        var resultType = result as OkObjectResult;
        var resultList=resultType.Value as List<EmployeeDto>;

        //Assert
        Assert.NotNull(result);
        Assert.NotNull(resultList);
        Assert.IsType<List<EmployeeDto>>(resultType.Value);
        Assert.Equal(5, resultList.Count);

    }



    [Fact]
    public async void Task_Delete_Employee_ReturnOkResult() { 

        var controller = new EmployeeController(employeeRepository);
        var id = 7;
        var data = controller.DeleteEmployeeById(id.ToString());
        var okResult=Assert.IsType<OkObjectResult>(data);
        Assert.Equal("success", okResult.Value);
    
    }
    
}