import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { StaffComponent } from './staff/staff.component';
import { MainPageComponent } from './main-page/main-page.component';
import { AuthGuard } from './auth.gaurd';
import { UserComponent } from './user/user.component';


const routes: Routes = [
  
  {path:'',redirectTo:'home',pathMatch:'full'},
  {path:'register',component:RegisterComponent},
  {path:'logIN',component:LoginComponent},
  {path:'admin',component:AdminComponent, canActivate:[AuthGuard], data: {roles:['admin']}},
  {path:'home',component:HomeComponent},
  {path:'staff',component:StaffComponent },
  {path:'main',component:MainPageComponent, },
  {path:'user',component:UserComponent  }

  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
