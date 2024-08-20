import { Component } from '@angular/core';

@Component({
  selector: 'app-tabla-datos',
  templateUrl: './tabla-datos.component.html',
  styleUrl: './tabla-datos.component.css'
})
export class TablaDatosComponent {

  lusuarios: any[] = [
    {
     n:1,
     nombre: 'VMT dev',
     edad: 10,
     ciudad: 'Guayaquil',
     provincia: 1
    },
    {
      n: 2,
      nombre: 'VMT dev 2',
      edad: 21,
      ciudad: 'Pichincha',
      provincia: 2
    },
     {
      n:3,
      nombre: 'VMT dev 3',
      edad: 44,
      ciudad: 'Guayaquil',
      provincia: 1
     },
     {
      n: 4,
      nombre: 'VMT dev 4',
      edad: 51,
      ciudad: 'Manta',
      provincia: 3
     },
     {
      n:5,
      nombre: 'VMT dev 5',
      edad: 71,
      ciudad: 'Buciegas',
      provincia: 4
     },
  ]

  lciudades = [
    {
      idciudad: 1,
      ciudad: 'Guayaquil',
    },
    {
      idciudad: 2,
      ciudad: 'Pichincha',
    },
    {
      idciudad: 3,
      ciudad: 'Manta',
    },
    {
      idciudad: 4,
      ciudad: 'Buciegas',
    },
    {
      idciudad: 5,
      ciudad: 'Paltas',
    }
  ]

  lProvincias = [
    {
      idProv: 1,
      provincia: 'Guayas',
    },
    {
      idProv: 2,
      provincia: 'Quito',
    },
    {
      idProv: 3,
      provincia: 'Manabi',
    },
    {
      idProv: 4,
      provincia: 'Cuenca',
    },
    {
      idProv: 5,
      provincia: 'Loja',
    }
  ]

  getUserProvince(usuarioId: number): string {
    const user = this.lusuarios.find(user => user.n === usuarioId);
    const userProv:string | undefined = this.lProvincias.find(prov => prov.idProv == user.provincia)?.provincia
    return userProv != undefined ? userProv : "No existe la provincia con el id especificado";
  }
}
