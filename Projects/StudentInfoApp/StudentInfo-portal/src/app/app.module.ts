import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentsComponent } from './students/students.component';
import { StudentInsertComponent } from './students/student-insert/student-insert.component';
import { StudentUpdateComponent } from './students/student-update/student-update.component';
import { StudentListComponent } from './students/student-list/student-list.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentsComponent,
    StudentInsertComponent,
    StudentUpdateComponent,
    StudentListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
