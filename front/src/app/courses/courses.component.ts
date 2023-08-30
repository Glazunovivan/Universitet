import { Component } from '@angular/core';
import { Course } from '../models/course';
import { CoursesService } from '../services/courses.service';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css']
})
export class CoursesComponent {

  courses: Course[] = [];

  constructor(private courseService: CoursesService){}
  
  ngOnInit(): void{
      this.courseService
          .getAll()
          .subscribe((result: Course[]) => (this.courses = result));
     
  }
}
