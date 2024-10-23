import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EstudiantesModule } from './estudiantes/estudiantes.module'; // Importa el StudentsModule
import { CalificacionesModule } from './calificaciones/calificaciones.module'; // Importa el StudentsModule
import { RouterModule } from '@angular/router';
import { HeaderComponent } from './header/header.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    EstudiantesModule,
    CalificacionesModule,
    FormsModule,
    RouterModule.forRoot([]), // Si tienes rutas definidas, ponlas aquí
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
