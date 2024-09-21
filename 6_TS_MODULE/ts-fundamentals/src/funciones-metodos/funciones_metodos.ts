let listaEstudiantes = [
    {
      id: 1,
      identificacion: 'EC123001',
      nombre: 'Jeyson',
      apellido: 'Jaramillo',
      curso: 'Primero',
      nota: 5
    },
    {
      id: 2,
      identificacion: 'EC123002',
      nombre: 'Juan',
      apellido: 'Piguave',
      curso: 'Tercero',
      nota: 8
    }, {
      id: 3,
      identificacion: 'EC123003',
      nombre: 'Mario',
      apellido: 'Piguave',
      curso: 'Tercero',
      nota: 8
    }, {
      id: 4,
      identificacion: 'EC123003',
      nombre: 'Efrain',
      apellido: 'Díaz',
      curso: 'Noveno',
      nota: 10
    }];

    // metodo find devuelve un solo objeto de la lista (Objeto = String, array o cualquier cosa)

    let estudiante = listaEstudiantes.find( estudiante => estudiante.identificacion ==  'EC123002'); 
    console.log(estudiante);

    // metodo filter devuelve una lista de objetos en base a una condición
    // Devolver una lista con los estudiantes de curso con valor 'Tercero'
    