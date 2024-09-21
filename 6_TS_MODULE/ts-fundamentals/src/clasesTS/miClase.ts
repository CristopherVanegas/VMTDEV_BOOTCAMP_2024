
class MiClase {
    constructor(
        private _nombre: string,
        private _valor: number,
        private _dataCuentas: any,
        private _testOp?: string
    ) { };

    get getNombre(): string {
        return this._nombre;
    }

    set setNombre(nombre: string) {
        this._nombre = nombre;
    } 

    get getCuentas() {
        return this._dataCuentas['dataCuentasX']['ahorrosX']['estadoCuenta'];
    }
}

