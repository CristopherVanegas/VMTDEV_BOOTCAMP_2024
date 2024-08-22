import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Persona } from '../../datasource/persona.interface';

@Component({
  selector: 'app-boton-dinamico',
  templateUrl: './boton-dinamico.component.html',
  styleUrl: './boton-dinamico.component.css'
})
export class BotonDinamicoComponent {
  @Input()
  valueButton: string = "Editar";

  @Input()
  registroPersona?: Persona;

  @Output()
  eventoRegistro = new EventEmitter<Persona>();

  eventoClickBoton() {
    this.eventoRegistro.emit(this.registroPersona);
  }
}
