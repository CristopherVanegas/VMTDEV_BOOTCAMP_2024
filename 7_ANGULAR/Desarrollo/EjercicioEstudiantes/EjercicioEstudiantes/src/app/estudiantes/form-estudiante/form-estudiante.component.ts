import { Component } from '@angular/core';
import { Estudiante } from '../../models/estudiante.model';

@Component({
  selector: 'app-form-estudiante',
  templateUrl: './form-estudiante.component.html',
  styles: ``
})
export class FormEstudianteComponent {
  estudiante: Estudiante = {
    id: 0,
    nombres: '',
    apellidos: '',
    dob: '',
    curso: ''
  };

  estudiantes: Estudiante[] = [];

  addEstudiante() {
    this.estudiante.id = this.estudiantes.length + 1; // Asigna un ID único
    this.estudiantes.push({ ...this.estudiante });
    console.log(this.estudiantes); // Muestra los datos en consola
    this.resetForm();
  }

  resetForm() {
    this.estudiante = {
      id: 0,
      nombres: '',
      apellidos: '',
      dob: '',
      curso: ''
    };
  }
}
