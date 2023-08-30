import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Group } from '../models/group';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from '../environment';

@Injectable({
  providedIn: 'root'
})
export class GroupsService {
  private url = 'Group';

  constructor(private http: HttpClient) { }

  public getAll() : Observable<Group[]>
  {
      return this.http.get<Group[]>(`${environment.apiUrl}/${this.url}`); 
  }
}
