import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.sass']
})
export class StudentListComponent implements OnInit {

  result:any;
    constructor(private router:Router,private http:HttpClient){}

    ngOnInit(){
        this.http.get<any>('https://localhost:44347/api/Student').subscribe(res => {
            this.result = res;
        });
    }
    update(id:number)
    {
        this.router.navigateByUrl("['/update',id]");
    }
    delete(id:number)
    {
      this.http.delete<any>("https://localhost:44347/api/Student"+id).subscribe(res => {
        this.result = res;
    });
    }
}
