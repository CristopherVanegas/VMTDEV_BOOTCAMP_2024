import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-miprimercomponente',
  templateUrl: './miprimercomponente.component.html'
})
export class MiprimercomponenteComponent {
  @Output()
  banderaAutenticacion = new EventEmitter()

  nombreUser: string = '';
  passwordUser: string = '';

  mostrarNombre() {
    console.log({
      'User: ': this.nombreUser,
      'Passwd:': this.passwordUser
    })
  }
  eventoBanderaCambioPantalla() {
    this.banderaAutenticacion.emit("CAMBIO");
  }
}
