import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StudentsViewsComponent } from './components/students.component';

const routes: Routes = [
  {
    path: '',
    component: StudentsViewsComponent
  },
  {
    path: 'students',
    component: StudentsViewsComponent
  },
 
  
];



@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
