import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewPersonasComponent } from './view-personas/view-personas.component';
import { BotonDinamicoComponent } from './shared/boton-dinamico/boton-dinamico.component';

@NgModule({
  declarations: [
    AppComponent,
    ViewPersonasComponent,
    BotonDinamicoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
