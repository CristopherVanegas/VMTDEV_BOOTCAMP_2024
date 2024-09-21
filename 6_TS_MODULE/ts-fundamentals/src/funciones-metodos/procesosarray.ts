import { jsonPractica } from './data-practica';

    interface iVarEjemploDesestruct {
        ex1: string,
        ex2: number
    }

    interface ivariable {
        valor1: string,
        valor2: number,
        valor3: boolean,
        valor4?: string | number | boolean,
        metodo1():void,
        valStruct: iVarEjemploDesestruct
    }

    let variableDinamica:any = true;
    variableDinamica = 'Boot';


    // 1. Obtener todos los titulos entregados de todos los usuarios
    
    var titulosCompletados: string [] = [];
    
     // forEach -> Ejecuta código por cada valor del arreglo. No devuelve algún objeto.
     jsonPractica.forEach(registro => {
        if(registro.completed){
            titulosCompletados.push(registro.title);
        }
     });
   //  console.log(titulosCompletados);
    
     // 2. Validar si algún título entregado se repite
    
     // map -> Ejecuta código sobre los valores de un array o ejecuta código por cada elemento del array. Devuelve los elementos procesados o el array intacto.
    
     let titulosCompletadosProcesados = titulosCompletados.map( titulo => {
        if(titulosCompletados.filter(tproceso => tproceso == titulo).length >1){
            return titulo;
        }
     });
    
      /*function validaRepetido(titulo: string){
        let registrosTitulo = titulosCompletados.filter( tituloAValidar => tituloAValidar === titulo);
        if(registrosTitulo.length > 1)
            {
                return titulo+ ' SE REPITE '+ registrosTitulo.length;
            }
     }*/

    // console.log(titulosCompletadosProcesados);

     // 3. Obtener las títulos completados por un usuario específico. 
     // EJERCICIO EN CLASE

     let titulosCompletadosPorUser: string []= [];

     function titulosCompletadosByUser(userid: number): string {
         jsonPractica.forEach(registroUsuario => {
            if(registroUsuario.userId == userid && registroUsuario.completed){
                titulosCompletadosPorUser.push(registroUsuario.title);
            }
         });
         return 'USUARIO '+ userid + ' TIENE '+ titulosCompletadosPorUser.length +' TITULOS COMPLETADOS';
     }

     console.log(titulosCompletadosByUser(1));
     console.log(titulosCompletadosPorUser);

     // 4. OBTENER LA CANTIDAD DE TITULOS ENTREGADOS Y NO ENTREGADOS POR USUARIO

     interface dataResumenUsuario {
        tipo: String,
        cantidad: number
     };
     function dataResumenUsuario(usuarioId: number): dataResumenUsuario[]{
         let completados = 0;
         let noCompletados = 0;
         jsonPractica.forEach( registroUsuario => {
            if(registroUsuario.userId === usuarioId){
                if(registroUsuario.completed){
                    completados++;
                }else {
                    noCompletados++;
                }
            }
         });
         return [
            {
                'tipo': 'Completados', 
                cantidad: completados
            },
            {
                tipo: 'No completados',
                'cantidad': noCompletados
            }
         ];
     }

     console.log(dataResumenUsuario(1));


 export {}