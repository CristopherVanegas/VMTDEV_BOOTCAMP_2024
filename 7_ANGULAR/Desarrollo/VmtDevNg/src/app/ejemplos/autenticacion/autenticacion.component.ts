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
    console.log(`Al clickear guardar, dataCambio dispara: ${dataCambio}`);
    console.log(`En toggleAutentication, autenticacion.component.html renderiza: ${dataCambio}, desde ${this.pantallaPresentacion}`);
    this.pantallaPresentacion = dataCambio;
  }
}
