import { Group } from "./group";

export class Student{
    id?: number;
    name = "";
    lastname = "";
    middlename = "";
    group?: Group;

    constructor(Name: string, Lastname: string, Middlename: string){
        this.name = Name;
        this.lastname = Lastname;
        this.middlename = Middlename;
    }
}