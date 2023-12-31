﻿using SchoolManagementSystemApi.ModelDto;
using SchoolManagementSystemApi.Models;

namespace SchoolManagementSystemApi.Services
{
    public interface IEmployeeRepository
    {
        public ICollection<EmployeeDto> GetAllEmployees();
        public ICollection<EmployeeDto> GetAllEmployeesByType(string employeeType);
    }
}
