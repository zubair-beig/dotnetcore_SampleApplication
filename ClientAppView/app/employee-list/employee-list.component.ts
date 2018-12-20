import { Component,OnInit } from '@angular/core';
import { EmployeeService  } from "../shared/employee.service";
import {Employee} from "../shared/employee-model";
@Component({    
    selector: 'app-employee-list',
    templateUrl:'./employee-list.component.html',
    styles: []  
  })
  export class EmployeeListComponent implements OnInit {

    title = "Employee";
    constructor(private employeeService:EmployeeService){

    }
    ngOnInit(){
     this.employeeService.getEmployeeList();
    }
    showForEdit(id:number){
        this.employeeService.getEmployeeByID(id);
    }
    onDelete(id:number){
      if(confirm('Are you sure. You want delete this?')==true){

      this.employeeService.deleteEmployee(id)
      .subscribe(x=>{
        this.employeeService.getEmployeeList();
      })
      }
    }


  }
  