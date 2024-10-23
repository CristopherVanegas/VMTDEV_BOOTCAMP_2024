import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { FormCalificacionComponent } from './form-calificaciones/form-calificaciones.component';



@NgModule({
  declarations: [
    FormCalificacionComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
  ]
})
export class CalificacionesModule { }
