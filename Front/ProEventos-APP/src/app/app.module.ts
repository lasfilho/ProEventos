import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventoComponent } from './evento/evento.component';
import { PalestranteComponent } from './palestrante/palestrante.component';

@NgModule({
  declarations: [
    AppComponent,
    EventoComponent,
    PalestranteComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule


  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
