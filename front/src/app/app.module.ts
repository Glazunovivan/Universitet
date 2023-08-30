import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import {Routes, RouterModule} from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { StudentsComponent } from './students/students.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { HttpClientModule } from '@angular/common/http';
import { GroupsComponent } from './components/groups/groups.component';
import { StudentEditComponent } from './students/student-edit/student-edit.component';
import { CoursesComponent } from './components/courses/courses.component';

const appRoutes: Routes = [
  {path:'', component: HomeComponent},
  {path:'students', component: StudentsComponent},
  {path: 'groups',component: GroupsComponent},
  {path: 'courses', component: CoursesComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StudentsComponent,
    StudentEditComponent,
    GroupsComponent,
    HeaderComponent,
    FooterComponent,
    StudentEditComponent,
    CoursesComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
