import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/models/student';
import { StudentService } from 'src/app/services/student.services';

@Component({
  selector: 'app-student-edit',
  templateUrl: './student-edit.component.html',
  styleUrls: ['./student-edit.component.css']
})

export class StudentEditComponent implements OnInit {

  addStudentRequest: Student = {
    lastname: '',
    name: '',
    middlename: ''
  };

  constructor(private studentService: StudentService) {}
  ngOnInit(): void{

  }

  addStudent(){
    this.studentService.addStudent(this.addStudentRequest);
  }
}
