import { Component } from '@angular/core';
import { lpersonas } from '../datasource/dataejemplo';
import { Persona } from '../datasource/persona.interface';

@Component({
  selector: 'app-view-personas',
  templateUrl: './view-personas.component.html',
})
export class ViewPersonasComponent {
  dataPersonas: Persona[] = lpersonas;

  obtenerGenero(g: string): string {
    return g == "M" ? "Masculino" : (g == "F" ? "Femenino" : "Género no definido")
  }

  funcionPersona(persona: Persona) {
    console.log(persona);
  }
}
