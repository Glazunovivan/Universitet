import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from '../environment';
import { Teacher } from '../models/teacher';

@Injectable({
  providedIn: 'root'
})
export class TeachersService {
  private url = 'Teacher';

  constructor(private http: HttpClient) { }

  public getAll() : Observable<Teacher[]>
  {
      return this.http.get<Teacher[]>(`${environment.apiUrl}/${this.url}`); 
  }
}
