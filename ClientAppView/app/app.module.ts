import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { HttpModule} from '@angular/http';

import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employee.component';
import {EmployeeListComponent} from './employee-list/employee-list.component'
import { EmployeeService } from "./shared/employee.service";
import { Employee } from './shared/employee-model';
@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    EmployeeListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [EmployeeService,Employee],
  bootstrap: [AppComponent]
})
export class AppModule { }
