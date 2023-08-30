import { Course } from "./course";
import { Group } from "./group";

export class Student{
    id?: number;
    name = "";
    lastname = "";
    middlename = "";
    constructor(Name: string, Lastname: string, Middlename: string){
        this.name = Name;
        this.lastname = Lastname;
        this.middlename = Middlename;
    }

    
    addGroup(group: Group): boolean
    {
        if(group == null)
        {
            return false;
        }
        return true;
    };
}