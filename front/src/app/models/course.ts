import { ContentCourse } from "./contentCourse";
import { Topic } from "./topic";

export class Course{
    id?: number;
    name = "";
    content: ContentCourse;
    topics?: Topic[];
}