using Microsoft.EntityFrameworkCore;
using SchoolManagementSystemApi.Data;
using SchoolManagementSystemApi.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<SchoolManagementApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolManagementSystemApiContext") ?? throw new InvalidOperationException("Connection string 'SchoolManagementSystemApiContext' not found.")));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ISchoolRepository, SchoolRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
var app = builder.Build();

app.MapGet("/", () => "Joy Sree Rama, API is Running");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

 // test from git hub web 1
        // test from git hub web 2
        // test from git hub web 3

app.Run();
