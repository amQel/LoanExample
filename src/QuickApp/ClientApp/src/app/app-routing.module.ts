
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { NotFoundComponent } from "./components/not-found/not-found.component";
import { AuthGuard } from './services/auth-guard.service';
import { InstallmentComponent } from './components/installment/installment.component';
import { AuthService } from './services/auth.service';


const routes: Routes = [
  { path: "installment", component: InstallmentComponent, canActivate: [AuthGuard], data: { title: "Calculations" } },
  { path: "", redirectTo: "/installment", pathMatch: "full" },
  { path: "**", component: NotFoundComponent, data: { title: "Page Not Found" } }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [AuthService, AuthGuard]
})
export class AppRoutingModule { }
