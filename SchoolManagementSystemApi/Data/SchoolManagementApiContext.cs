using Microsoft.EntityFrameworkCore;
using SchoolManagementSystemApi.Models;
using System.Data.Common;

namespace SchoolManagementSystemApi.Data
{
    public class SchoolManagementApiContext: DbContext


    {
        public SchoolManagementApiContext(DbContextOptions<SchoolManagementApiContext> options)
          : base(options)
        {
        }

        public DbSet<SchoolManagementSystemApi.Models.School> Schools { get; set; }
        public DbSet<SchoolManagementSystemApi.Models.Student> Students { get; set; }

        public DbSet<SchoolManagementSystemApi.Models.Employee> Employees { get; set; }
    }
}
