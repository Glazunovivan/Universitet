import { Component } from '@angular/core';
import { Group } from 'src/app/models/group';
import { GroupsService } from 'src/app/services/groups.service';

@Component({
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrls: ['./groups.component.css']
})
export class GroupsComponent {

  groups: Group[] = [];

  constructor(private groupService: GroupsService){}
  
  ngOnInit(): void{
      this.groupService
          .getAll()
          .subscribe((result: Group[]) => (this.groups = result));
     
  }
}
