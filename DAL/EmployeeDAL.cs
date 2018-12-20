using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using myApp.Entities;

namespace myApp.DAL{

public class EmployeeDAL
{
   private  EmployeesContext _employeeContext;

   public EmployeeDAL(EmployeesContext employeesContext){
       _employeeContext = employeesContext;
   }
  public long SaveEmployee(Employee Employee){

       var emp =  _employeeContext.Employees.Add(Employee);
        if(Employee.Id > 0)
        {
            emp.State = EntityState.Modified;
        }
        return _employeeContext.SaveChanges();
    } 
    public Employee GetEmployeeByID(int ID){

        return _employeeContext.Employees.Where(x=>x.Id==ID).First();
    }

    public Employee GetEmployeeByName(string Name){
        return _employeeContext.Employees.Where(x=>x.FirstName + x.LastName == Name).First();
    }

    public List<Employee> GetEmployeeList(){

         return _employeeContext.Employees.ToList();

    }
    public long DeleteEmployee(int ID){
        var emp  = _employeeContext.Employees.Find(ID);
        _employeeContext.Employees.Remove(emp);
        return _employeeContext.SaveChanges();

    }


}



}