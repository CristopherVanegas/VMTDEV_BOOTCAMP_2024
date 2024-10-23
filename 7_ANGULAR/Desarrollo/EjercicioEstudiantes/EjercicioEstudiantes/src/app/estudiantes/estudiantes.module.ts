import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { FormEstudianteComponent } from './form-estudiante/form-estudiante.component';
import { FormRepresentantesComponent } from './form-representantes/form-representantes.component';


@NgModule({
  declarations: [
    FormEstudianteComponent,
    FormRepresentantesComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ]
})
export class EstudiantesModule { }
