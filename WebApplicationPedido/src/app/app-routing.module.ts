import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CondimentosComponent } from './components/condimentos/condimentos.component';

const routes: Routes = [{
  path: 'condimentos', component: CondimentosComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
