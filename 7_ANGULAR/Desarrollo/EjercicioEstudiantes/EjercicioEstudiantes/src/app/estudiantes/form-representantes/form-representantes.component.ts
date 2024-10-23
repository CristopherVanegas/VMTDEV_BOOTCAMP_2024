import { Component } from '@angular/core';
import { Representante } from '../../models/representante.model';

@Component({
  selector: 'app-form-representantes',
  templateUrl: './form-representantes.component.html',
  styles: ``
})
export class FormRepresentantesComponent {
  representante: Representante = {
    id: 0,
    nombres: '',
    apellidos: '',
    relacion: '',
    telefono: 0,
    email: ''
  };

  representantes: Representante[] = [];

  agregarRepresentante() {
    this.representante.id = this.representantes.length + 1; // Asigna un ID único
    this.representantes.push({ ...this.representante });
    console.log(this.representantes); // Muestra los datos en consola
    this.resetForm();
  }

  resetForm() {
    this.representante = {
      id: 0,
      nombres: '',
      apellidos: '',
      relacion: '',
      telefono: 0,
      email: ''
    };
  }
}
