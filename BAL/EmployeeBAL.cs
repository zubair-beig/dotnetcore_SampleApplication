using System.Collections.Generic;
using myApp.DAL;
using myApp.Entities;

namespace myApp.BAL {

public class EmployeeBAL
{
    private EmployeeDAL _employeeDAL;

    public  EmployeeBAL(EmployeeDAL employeeDAL){
        _employeeDAL = employeeDAL;
    }
    public bool SaveEmployee(Employee Employee){
        
       return  _employeeDAL.SaveEmployee(Employee) > 0 ? true : false;
    } 
    public Employee GetEmployeeByID(int ID){

        return _employeeDAL.GetEmployeeByID(ID);
    }

    public Employee GetEmployeeByName(string Name){
        return _employeeDAL.GetEmployeeByName(Name);
    }

    public List<Employee> GetEmployeeList(){

        return _employeeDAL.GetEmployeeList();

    }
    public bool DeleteEmployee(int ID){
        return _employeeDAL.DeleteEmployee(ID) > 0?true:false;
    }

}


}