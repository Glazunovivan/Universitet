import { Component, OnInit } from '@angular/core';
import { StudentService } from '../services/student.services';
import { Student } from '../models/student';
import { Router } from '@angular/router';

@Component({
    selector: 'app-students',
    templateUrl: './students.component.html',
    styleUrls: ['./students.component.css']
})

export class StudentsComponent implements OnInit{
    
    students: Student[] = [];
    student: Student;   //студент которого редактируем

    constructor(private studentService: StudentService, private router: Router){}

    ngOnInit(): void{
        this.studentService
            .getAll()
            .subscribe((result: Student[]) => (this.students = result));
       
    }
    addStudent(){
        this.student = new Student("","","");
    }
    openStudentById(id: number)
    {
        this.router.navigate(['student-edit',id]);
    } 
    openStudent(s: Student)
    {
        this.student = s;
        this.router.navigate(['student-edit',s.id]);
    } 
}