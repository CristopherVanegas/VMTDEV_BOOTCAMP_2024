import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MiprimercomponenteComponent } from './ejemplos/miprimercomponente/miprimercomponente.component';
import { FormsModule } from '@angular/forms';
import { AutenticacionComponent } from './ejemplos/autenticacion/autenticacion.component';
import { RegistroUsuariosComponent } from './ejemplos/registro-usuarios/registro-usuarios.component';

@NgModule({
  declarations: [
    AppComponent,
    MiprimercomponenteComponent,
    AutenticacionComponent,
    RegistroUsuariosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
