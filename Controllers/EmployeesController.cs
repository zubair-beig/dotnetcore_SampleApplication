using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myApp.BAL;
using myApp.Entities;

namespace myApp.Controllers{

[Route("api/[Controller]/[Action]")]
public class EmployeesController : Controller
{
    private EmployeeBAL _employeeBAL;
    public EmployeesController(EmployeeBAL employeeBAL){
        _employeeBAL = employeeBAL;
    }


    [HttpPost]
    public bool Save([FromBody]Employee  employee){
            return _employeeBAL.SaveEmployee(employee);
              
    }
    [HttpGet]
    public List<Employee> GetEmployeeList()
    {
        return _employeeBAL.GetEmployeeList();
    }

    [HttpGet]
    public Employee GetEmployeeByID(int id){
        
        return _employeeBAL.GetEmployeeByID(id);
    }

    [HttpDelete]
    public bool DeleteEmployee(int id){
        return _employeeBAL.DeleteEmployee(id);
    }
}


}