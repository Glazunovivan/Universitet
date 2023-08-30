import { Group } from "./group";

export class Student{
    id: number;
    name = "";
    lastname = "";
    middlename = "";
    group: Group;
    
    constructor(Name: string, Lastname: string, Middlename: string, group: Group){
        this.name = Name;
        this.lastname = Lastname;
        this.middlename = Middlename;
        this.group = group;
    }

    public addGroup(group: Group): boolean
    {
        if(group == null)
        {
            return false;
        }
        return true;
    };
}