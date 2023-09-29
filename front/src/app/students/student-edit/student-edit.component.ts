import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Student } from 'src/app/models/student';
import { StudentService } from 'src/app/services/student.services';

@Component({
  selector: 'app-student-edit',
  templateUrl: './student-edit.component.html',
  styleUrls: ['./student-edit.component.css']
})

export class StudentEditComponent implements OnInit {

  editStudentResponse: Student ={
    lastname: '',
    name: '',
    middlename: ''
  };

  addStudentRequest: Student = {
    lastname: '',
    name: '',
    middlename: ''
  };

  constructor(private studentService: StudentService, private route: ActivatedRoute) {}

  ngOnInit(): void{

    this.route.paramMap.subscribe({
      next: (p)=> {
        const id = p.get('id');
        
        this.studentService.getStudentById(Number('id'))
          .subscribe(
            { next: (response) =>
                  this.editStudentResponse = response
            });
      }
    });
  }

  addStudent(){
    this.studentService.addStudent(this.addStudentRequest);
  }
}
