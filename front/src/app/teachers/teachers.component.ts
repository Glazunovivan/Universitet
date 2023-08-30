import {Component, OnInit} from '@angular/core';
import { TeacherService } from '../services/teachers.service';
import { Teacher } from '../models/teacher';
@Component({
    selector: 'app-teachers',
    templateUrl: './teachers.component.html',
    styleUrls: ['./teachers.component.css']
})

export class TeachersComponent implements OnInit{
    
    teachers: Teacher[] = [];

    constructor(private teacherService: TeacherService){}

    ngOnInit(): void{
        this.teacherService
            .getAll()
            .subscribe((result: Teacher[]) => (this.teachers = result));
       
    }
}
