import { Component } from '@angular/core';
import { MiprimercomponenteComponent } from '../miprimercomponente/miprimercomponente.component';

@Component({
  selector: 'app-autenticacion',
  templateUrl: './autenticacion.component.html',
  styleUrl: './autenticacion.component.css'
})
export class AutenticacionComponent {
  componente: MiprimercomponenteComponent = new MiprimercomponenteComponent();
  pantallaPresentacion: string = 'LOGIN';

  toggleAutentication(dataCambio: string) {
    console.log(dataCambio);
    console.log(this.pantallaPresentacion);

    if (this.pantallaPresentacion === 'LOGIN') {
      this.pantallaPresentacion = 'REGISTRO';
    }
    else if (this.pantallaPresentacion === 'REGISTRO') {
      this.pantallaPresentacion = 'LOGIN';
    }
  }
}
