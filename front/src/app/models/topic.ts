import { Course } from "./course";

export class Topic{
    id?:number;
    course: Course; //курс
    number: number;     //номер темы (для сортировки)
    name: string;   //название темы
}