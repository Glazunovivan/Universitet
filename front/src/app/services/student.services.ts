import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { HttpClient } from '@angular/common/http';
import { Student } from '../models/student';
import { environment } from '../environment';

@Injectable({
    providedIn: 'root'
})
export class StudentService{
    private url = 'Student';

    constructor(private http: HttpClient) { }

    public getAll() : Observable<Student[]>
    {
        return this.http.get<Student[]>(`${environment.apiUrl}/${this.url}`); 
    }
    public getStudent(data: Student): Observable<Student[]>{
        return this.http.get<Student[]>(`${environment.apiUrl}/${this.url}/${data.id}`); 
    }

    public getStudentById(id: number): Observable<Student>{
        return this.http.get<Student>(`${environment.apiUrl}/${this.url}/${id}`); 
    }

    public addStudent(data: Student){
        return this.http.post<Student>(`${environment.apiUrl}/${this.url}`, data);
    }

    public deleteStudent(id: number)
    {
        return this.http.delete<Student>(`${environment.apiUrl}/${this.url}/${id}`);
    }

    public updateStudent(data: Student)
    {
        return this.http.put<Student>(`${environment.apiUrl}/${this.url}`,data);
    }

}