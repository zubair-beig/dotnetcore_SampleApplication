import { Component,OnInit } from '@angular/core';
import { EmployeeService  } from "../shared/employee.service";
import  {NgForm} from "@angular/forms"
@Component({
    selector: 'app-employee',
    templateUrl:'./employee.component.html',
    styles: []  
  })
  export class EmployeeComponent implements OnInit {

    title = "Employee";
    constructor(private employeeService:EmployeeService){

    }
    ngOnInit(){
      this.resetForm();
    }
    resetForm(form? : NgForm){
      if(form !=null)
         form.reset();
      this.employeeService.selectedEmployee ={
        id:0,
        firstName:'',
        lastName:'',
        description:''
      }

    }
    onSubmit(form : NgForm){
     this.employeeService.postEmployee(form.value)
     .subscribe(data =>{
       this.resetForm();
       this.employeeService.getEmployeeList();
     })   
    }
  }
  