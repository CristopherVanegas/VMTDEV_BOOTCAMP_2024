import { Component } from '@angular/core';

@Component({
  selector: 'app-miprimercomponente',
  templateUrl: './miprimercomponente.component.html'
})
export class MiprimercomponenteComponent {
  nombreUser: string = '';
  passwordUser: string = '';

  mostrarNombre() {
    console.log({
      'User: ': this.nombreUser,
      'Passwd:': this.passwordUser
    })
  }
}
