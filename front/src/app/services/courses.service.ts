import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from '../environment';
import { Course } from '../models/course';

@Injectable({
  providedIn: 'root'
})
export class CoursesService {
  private url = "Courses";

  constructor(private http: HttpClient) { }

  public getAll() : Observable<Course[]>
  {
      return this.http.get<Course[]>(`${environment.apiUrl}/${this.url}`); 
  }
}
