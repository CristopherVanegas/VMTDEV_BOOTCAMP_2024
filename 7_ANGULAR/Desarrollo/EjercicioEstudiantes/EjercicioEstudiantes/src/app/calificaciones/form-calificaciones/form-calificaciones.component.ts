import { Component } from '@angular/core';
import { Calificacion } from '../../models/calificacion.model';

@Component({
  selector: 'app-calificacion-form',
  templateUrl: './form-calificaciones.component.html',
  styles: ``
})
export class FormCalificacionComponent {
  calificacion: Calificacion = {
    nombreTarea: '',
    descripcion: '',
    fechaInicio: '',
    fechaFin: '',
    calificacion: 0,
    estado: false
  };

  calificaciones: Calificacion[] = [];

  addCalificacion() {
    this.calificacion.estado = this.calificacion.calificacion >= 7;
    this.calificaciones.push({ ...this.calificacion });
    console.log(this.calificaciones); // Muestra los datos en consola
    this.resetForm();
  }

  resetForm() {
    this.calificacion = {
      nombreTarea: '',
      descripcion: '',
      fechaInicio: '',
      fechaFin: '',
      calificacion: 0,
      estado: false
    };
  }
}
