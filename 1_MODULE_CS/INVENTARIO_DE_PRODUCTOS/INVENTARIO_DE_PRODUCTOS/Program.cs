/*
 INTEGRANTES
JOSHUA BRYAN SAREZ CHIRIGUAYA
BAÑO CORDERO CHRISTELL NICOLE
BORIS ISMAEL SUAREZ CONTRERAS
CRISTOPHER JULINHO VANEGAS SANTI
 */

using System.Runtime.Intrinsics.X86;
using System;
using System.Runtime.Intrinsics.Arm;

namespace INVENTARIO_DE_PRODUCTOS
{
    class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
    }
    class Inventario
    {
        public List<Producto> listaProductos = new List<Producto>();
        string nombreProducto = "";
        double precioProducto = 0.00;
        int stockProducto = 0;

        public void IngresarProducto()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("AGREGAR PRODUCTO");
                Console.ResetColor();
                Console.Write("Ingrese el nombre del producto: ");
                Console.ForegroundColor = ConsoleColor.Green;
                nombreProducto = Console.ReadLine();
                Console.ResetColor();

                Console.Write("Ingrese el precio del producto: ");
                Console.ForegroundColor = ConsoleColor.Green;
                precioProducto = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.Write("Ingrese el stock del producto: ");
                Console.ForegroundColor = ConsoleColor.Green;
                stockProducto = int.Parse(Console.ReadLine());
                Console.ResetColor();

                if (String.IsNullOrWhiteSpace(nombreProducto))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingrese un nombre de producto no vacio");
                }
            }
            while (String.IsNullOrWhiteSpace(nombreProducto));


            listaProductos.Add(new Producto
            {
                id = listaProductos.Count + 1,
                nombre = nombreProducto,
                precio = precioProducto,
                stock = stockProducto
            });
        }

        public void InicializarInventario()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("INICIALIZANDO INVENTARIO");
            listaProductos = new List<Producto>() {
                new Producto {
                    id = 1,
                    nombre = "Billetera",
                    precio = 3.5,
                    stock = 20
                },
                new Producto {
                    id = 2,
                    nombre = "Cartera",
                    precio = 5.5,
                    stock = 10
                },
                new Producto {
                    id = 3,
                    nombre = "Bolso",
                    precio = 10.5,
                    stock = 5
                },
                new Producto {
                    id = 4,
                    nombre = "Mochila",
                    precio = 15.5,
                    stock = 3
                },
            };
        }

        public void EliminarProducto()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ELIMINAR PRODUCTO");
            Console.Clear();
            Console.Write("Ingrese el ID del producto a eliminar: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int idProducto = int.Parse(Console.ReadLine());

            Producto productoAEliminar = listaProductos.Find(p => p.id == idProducto);
            if (productoAEliminar != null)
            {
                listaProductos.Remove(productoAEliminar);
                Console.WriteLine($"Producto con ID {idProducto} eliminado correctamente.");
            }
            else
            {
                Console.WriteLine($"Producto con ID {idProducto} no encontrado.");
            }
            Console.ResetColor();
        }

        public void MostrarProducto()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MOSTRAR PRODUCTOS");
            Console.ResetColor();
            foreach (Producto producto in listaProductos)
            {
                Console.WriteLine($"ID del producto: {producto.id}, Nombre del producto: {producto.nombre}, Precio del producto: {producto.precio}, Stock: {producto.stock}");
            }
        }
        public void BuscarPorNombre()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("BUSCAR PRODUCTO POR NOMBRE");
                Console.Clear();
                Console.Write("Ingrese el nombre del producto a buscar: ");
                Console.ForegroundColor = ConsoleColor.Green;
                nombreProducto = Console.ReadLine();
                Console.ResetColor();

                if (String.IsNullOrWhiteSpace(nombreProducto))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingrese un nombre de producto no vacio");
                }
            }
            while (String.IsNullOrWhiteSpace(nombreProducto));


            foreach (Producto producto in listaProductos)
            {
                if (producto.nombre == nombreProducto)
                    Console.WriteLine($"ID del producto: {producto.id}, Nombre del producto: {producto.nombre}, Precio del producto: {producto.precio}, Stock: {producto.stock}");
            }
        }
        public void ActualizarProducto()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ACTUALIZAR PRODUCTO");
            Console.ResetColor();

            int idActualizar = 0;
            string nuevoNombre = "";
            double nuevoPrecio = 0.00;
            int nuevoStock = 0;
            bool isValidEntry = false;


            // PREGUNTO por el ID del producto que desea actualizar
            do
            {
                // TRY CATCH para que el ID sea un valor esperado
                try
                {
                    Console.ResetColor();
                    Console.Write("Ingrese el ID del producto que desea actualizar: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    idActualizar = Convert.ToInt16(Console.ReadLine());

                    if (idActualizar >= 0)
                        isValidEntry = true;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese un ID mayor o igual a 0!");
                    }
                }
                catch (FormatException ex)
                {
                    // Manejar la excepción FormatException
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error de formato: {ex.Message}");
                    Console.WriteLine("Por favor, ingrese solo enteros.");
                }
            }
            while (!isValidEntry);

            // PREGUNTO por el nuevo NOMBRE
            isValidEntry = false;
            do
            {
                // Actualizar NOMBRE
                Console.ResetColor();
                Console.Write("El nombre anterior del producto es ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{listaProductos[idActualizar].nombre}\n");
                Console.ResetColor();
                Console.Write($"Ingrese el nuevo nombre para el producto: ");
                Console.ForegroundColor = ConsoleColor.Green;
                nuevoNombre = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(nuevoNombre))
                {
                    listaProductos[idActualizar].nombre = nuevoNombre;  // guardo el nuevo nombre en la lista
                    isValidEntry = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingrese un nombre que no este vacio!");
                }
            }
            while (!isValidEntry);

            // PREGUNTO por el nuevo PRECIO
            isValidEntry = false;
            do
            {
                // TRY CATCH si desea actualizar PRECIO
                try
                {
                    Console.ResetColor();
                    Console.Write("El precio anterior del producto es ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{listaProductos[idActualizar].precio}\n");
                    Console.ResetColor();
                    Console.Write($"Ingrese el nuevo precio para el producto: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    nuevoPrecio = double.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    // Manejar la excepción FormatException
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error de formato: {ex.Message}");
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

                if (nuevoPrecio > 0)
                {
                    listaProductos[idActualizar].precio = nuevoPrecio;  // guardo el nuevo nombre en la lista
                    isValidEntry = true;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingrese un valor mayor a 0!");
                }
            }
            while (!isValidEntry);

            // PREGUNTO por el nuevo STOCK
            isValidEntry = false;
            do
            {
                // TRY CATCH si desea actualizar STOCK
                try
                {
                    Console.Write("El STOCK anterior del producto es ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{listaProductos[idActualizar].precio}\n");
                    Console.ResetColor();
                    Console.Write($"Ingrese el nuevo STOCK para el producto: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    nuevoStock = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    // Manejar la excepción FormatException
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error de formato: {ex.Message}");
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

                if (nuevoStock > 0)
                {
                    listaProductos[idActualizar].precio = nuevoPrecio;  // guardo el nuevo nombre en la lista
                    isValidEntry = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingrese un valor mayor a 0!");
                }
            }
            while (!isValidEntry);
        }
        public void CalcularValorTotalInventario()
        {
            double valorTotal = 0;
            foreach (var producto in listaProductos)
            {
                valorTotal += producto.precio * producto.stock;
            }
            Console.WriteLine($"El valor total del inventario es: {valorTotal:C}");
        }
        public void CalcularCantidadTotalProductos()
        {
            int cantidadTotal = 0;
            foreach (var producto in listaProductos)
            {
                cantidadTotal += producto.stock;
            }
            Console.WriteLine($"La cantidad total de productos en el inventario es: {cantidadTotal}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            inventario.InicializarInventario();     // Llena el inventario de productos.

            int opt = 0;
            do
            {
                Console.Clear();    // Limpia la pantalla al inicio
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("BIENVENIDOS AL INVENTARIO DE PRODUCTOS");
                Console.ResetColor();
                Console.WriteLine("[1] Agregar      Producto");
                Console.WriteLine("[2] Eliminar     Producto");
                Console.WriteLine("[3] Actualizar   Producto");
                Console.WriteLine("[4] Mostrar      Productos");
                Console.WriteLine("[5] Buscar       Producto por Nombre");
                Console.WriteLine("[6] Calcular     estadistica del Inventario");
                Console.WriteLine("[7] Salir\n");

                try
                {
                    Console.Write("Elige una opcion: ");
                    opt = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (FormatException ex)
                {
                    // Manejar la excepción FormatException
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error de formato: {ex.Message}");
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

                Console.Clear();
                switch (opt)
                {
                    case 1:
                        {
                            inventario.IngresarProducto();
                        }
                        break;

                    case 2:
                        {
                            inventario.EliminarProducto();
                        }
                        break;

                    case 3:
                        {
                            inventario.ActualizarProducto();
                        }
                        break;

                    case 4:
                        {
                            inventario.MostrarProducto();
                        }
                        break;

                    case 5:
                        {
                            inventario.BuscarPorNombre();
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine("CALCULAR ESTADISTICA DEL INVENTARIO");
                            inventario.MostrarProducto();
                            inventario.CalcularValorTotalInventario();
                            inventario.CalcularCantidadTotalProductos();
                        }
                        break;

                    case 7:
                        {
                            List<String> integrantes = new List<String>();
                            integrantes.Add("JOSHUA BRYAN SAREZ CHIRIGUAYA");
                            integrantes.Add("BAÑO CORDERO CHRISTELL NICOLE");
                            integrantes.Add("BORIS ISMAEL SUAREZ CONTRERAS");
                            integrantes.Add("CRISTOPHER JULINHO VANEGAS SANTI");

                            Console.WriteLine("\nByeeee!");
                            Console.WriteLine("Programa hecho por: \n\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < integrantes.Count; i++)
                            {
                                Thread.Sleep(500);
                                Console.WriteLine(integrantes[i]);
                            }

                            Console.ResetColor();
                            Environment.Exit(0);
                        }
                        break;


                    default:
                        {
                            Console.WriteLine("Ingrese una opcion valida!");
                        }
                        break;
                }
                Console.WriteLine("\nPresione la tecla 'enter' para continuar...");
                Console.ReadLine();
            } while (opt != 7);
        }
    }

}
