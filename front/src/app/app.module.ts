import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import {Routes, RouterModule} from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { StudentsComponent } from './students/students.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './components/footer/footer.component';

const appRoutes: Routes = [
  {path:'', component: HomeComponent},
  {path:'students', component: StudentsComponent},

]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StudentsComponent,
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
