import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-registro-usuarios',
  templateUrl: './registro-usuarios.component.html',
  styleUrl: './registro-usuarios.component.css'
})
export class RegistroUsuariosComponent {
  @Output()
  windowState = new EventEmitter();

  eventoRandom () {

  }
  toggleWindowState(): void {
    this.windowState.emit('CAMBIO');
  }
}
