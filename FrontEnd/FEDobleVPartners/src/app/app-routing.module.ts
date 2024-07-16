import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//Components
import { AddUserComponent } from './components/add-user/add-user.component';
import { LoginUserComponent } from './components/login-user/login-user.component';

const routes: Routes = [
  {path: '', redirectTo: 'loginUser', pathMatch: 'full'},
  {path: 'addUser', component: AddUserComponent},
  {path: 'loginUser', component: LoginUserComponent},
  {path: '**', redirectTo: 'loginUser', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
