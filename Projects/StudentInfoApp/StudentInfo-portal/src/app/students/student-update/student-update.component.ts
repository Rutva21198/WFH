import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student-update',
  templateUrl: './student-update.component.html',
  styleUrls: ['./student-update.component.sass']
})
export class StudentUpdateComponent implements OnInit {

  sformGroup : FormGroup;
  id:any;
  constructor(private builder:FormBuilder, private activatedRoute:ActivatedRoute,private http:HttpClient,private router:Router) { 

  }

  ngOnInit() {
    this.id = this.activatedRoute.snapshot.paramMap.get("id");
    console.log("sajfh"+this.id);
    this.sformGroup = this.builder.group({
      name:['',Validators.required],
      email:['',Validators.required],
      mobile:['',Validators.required],
      fee:['',Validators.required],
      course:['',Validators.required]
  })
  }
  submit()
  {
    this.http.put("https://localhost:44347/api/Student",{studentId:this.id,Name:this.sformGroup.value.name,
    Email:this.sformGroup.value.email,Mobile:this.sformGroup.value.mobile
     ,Fees:this.sformGroup.value.fee,Course:this.sformGroup.value.course}).subscribe(res => {
      console.log(res);
      this.router.navigate(['/list']);
    });
  }
}
