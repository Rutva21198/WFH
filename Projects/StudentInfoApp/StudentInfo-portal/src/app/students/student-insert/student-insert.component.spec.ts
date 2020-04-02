import { Component, OnInit } from '@angular/core';
import {FormBuilder,FormGroup, Validators} from '@angular/forms';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-student-insert',
  templateUrl: './student-insert.component.html',
  styleUrls: ['./student-insert.component.css']
})
export class StudentInsertComponent implements OnInit {
  
    sformGroup:FormGroup;

    constructor(private builder:FormBuilder,private http:HttpClient) {
        
    }

    ngOnInit(){
        this.sformGroup = this.builder.group({
            name:['',Validators.required],
            email:['',Validators.required],
            mobile:['',Validators.required],
            fee:['',Validators.required],
            course:['',Validators.required]
        })
    }
    submit(){
      // this.http.post<any>('https://localhost:44347/api/Student',{Name:this.sformGroup.value.name,
      // Email:this.sformGroup.value.email,Mobile:this.sformGroup.value.mobile
      // ,Fees:this.sformGroup.value.fee,Course:this.sformGroup.value.course}).subscribe(res => { 
      //     console.log(res);
          
      // });
      console.log(this.sformGroup);
  }
}