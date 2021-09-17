import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FilmesComponent } from './filmes/filmes.component';
import { LoginComponent } from './login/login.component';
import { SalasComponent } from './salas/salas.component';
import { SessoesComponent } from './sessoes/sessoes.component';

const routes: Routes = [
  {path: '', redirectTo: 'login', pathMatch: 'full'},
  {path: 'salas', component: SalasComponent}, 
  {path: 'filmes', component: FilmesComponent},
  {path: 'sessoes', component: SessoesComponent},
  {path: 'login', component: LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
