import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormEstudianteComponent } from './estudiantes/form-estudiante/form-estudiante.component';
import { FormRepresentantesComponent } from './estudiantes/form-representantes/form-representantes.component';
import { FormCalificacionComponent } from './calificaciones/form-calificaciones/form-calificaciones.component';

const routes: Routes = [
  { path: 'estudiantes', component: FormEstudianteComponent }, // Ruta para el componente de estudiantes
  { path: 'representantes', component: FormRepresentantesComponent }, // Ruta para el componente de representantes
  { path: 'notas', component: FormCalificacionComponent }, // Ruta para el componente de calificaciones
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
