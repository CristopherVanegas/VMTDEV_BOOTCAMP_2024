import * as datosEjercicio from '../datosEjecicio';

// 1. definir cuantos viajes ha realizado cada persona
// defino interfaces
interface Persona {
    id: number;
    name: string;
    age: number;
    phone: string;
}

interface DireccionOrigenPersona {
    id: number;
    person_id: number;
    address: string;
    latitude: number;
    longitude: number;
}

interface DatosDestino {
    id: number;
    person_id: number;
    address: string;
    latitude: number;
    longitude: number;
}

const persona: Persona[] = [
    // (tu array persona aquí)
];

const direccioOrigenPersona: DireccionOrigenPersona[] = [
    // (tu array direccioOrigenPersona aquí)
];

const datosDestino: DatosDestino[] = [
    // (tu array datosDestino aquí)
];