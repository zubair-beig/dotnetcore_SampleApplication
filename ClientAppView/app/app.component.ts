import { Component,OnInit } from '@angular/core';
import { EmployeeService } from "./shared/employee.service";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: [] ,
  providers:[EmployeeService] 
})
export class AppComponent implements  OnInit {
  title = 'app';
  constructor(private employeeService:EmployeeService){

  }
  ngOnInit(){

  }
}
