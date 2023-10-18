import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CondimentoService } from './condimento.service';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';
import { CondimentosComponent } from './components/condimentos/condimentos.component';


@NgModule({
  declarations: [
    AppComponent,
    CondimentosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],
  providers: [HttpClientModule, CondimentoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
