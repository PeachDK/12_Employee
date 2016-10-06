using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _12_Employee
{
    internal class EmployeeRepository
    {   int _id                     = 1;
        List<Employee> employeelist = new List<Employee>();
        internal int NextID()
        {
           return _id++;
        }
        internal void Clear()
        {
            employeelist.Clear();
        }

        internal int CountEmployees()
        {
            return employeelist.Count();
        }

        internal Employee CreateEmployee(string name, string type)
        {
           
            Employee _employee = new Employee(name, type, NextID());
            employeelist.Add(_employee);
            return _employee;
        }

        internal void SaveEmployee(Employee employee)
        {
           employeelist[employee.Id -1] = employee;
        }

        internal Employee LoadEmployee(int id)
        {
            return employeelist[id-1];
        }

        internal List<Employee> FindAllEmployees()
        {
            return employeelist;
        }
    }
}