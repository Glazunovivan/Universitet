import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { HttpClient } from '@angular/common/http';
import { Student } from '../models/student';
import { environment } from '../environment';

@Injectable({
    provideIn: 'root'
})
export class StudentService{
    private url = 'Student';

    constructor(private http: HttpClient) { }

    public getStudents() : Observable<Student[]>
    {
        return this.http.get<Student[]>(`${environment.apiUrl}/${this.url}`); 
    }
}