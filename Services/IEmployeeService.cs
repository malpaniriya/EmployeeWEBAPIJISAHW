﻿using EmployeeWEBAPIJISAHW.Models;

namespace EmployeeWEBAPIJISAHW.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        int AddEmployee(Employee employee);

        int UpdateEmployee(Employee employee);

        int DeleteEmployee(int id);
    }
}
