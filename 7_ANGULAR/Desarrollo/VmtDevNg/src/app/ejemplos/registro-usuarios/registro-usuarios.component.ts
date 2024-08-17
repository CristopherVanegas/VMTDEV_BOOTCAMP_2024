import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-registro-usuarios',
  templateUrl: './registro-usuarios.component.html',
  styleUrl: './registro-usuarios.component.css'
})
export class RegistroUsuariosComponent {
  @Output()
  banderaAutenticacion = new EventEmitter()

  eventoRandom () {

  }
  eventoBanderaCambioPantalla() {
    this.banderaAutenticacion.emit("LOGIN");
  }
}
