export interface Calificacion {
  nombreTarea: string;
  descripcion: string;
  fechaInicio: string;
  fechaFin: string;
  calificacion: number;
  estado: boolean;  // Estado (Si es 7 o mayor a 7 “Aprobado” ; Meno a 7 “Reprobado”) Se calcula en base a los datos ingresados en el modal
}
