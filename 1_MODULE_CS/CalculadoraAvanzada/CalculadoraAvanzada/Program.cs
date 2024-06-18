using System.Runtime.Intrinsics.Arm;

namespace CalculadoraAvanzada
{
    public class Calculadora
    {
        // Método para sumar dos números
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        // Método para restar dos números
        public double Restar(double a, double b)
        {
            return a - b;
        }

        // Método para multiplicar dos números
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Método para dividir dos números
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }
            return a / b;
        }
    }

    internal class Program
    {        
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> nums = new List<int>();
            Calculadora calculadora = new Calculadora();

            int opt = 0, aux = 0;
            double a, b;


            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a la calculadora avanzada!");
                Console.WriteLine("[1] Suma");
                Console.WriteLine("[2] Resta");
                Console.WriteLine("[3] Multiplicacion");
                Console.WriteLine("[4] Division");
                Console.WriteLine("[5] Mayor");
                Console.WriteLine("[6] Menor");
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
                
                switch (opt)
                {
                    case 1:
                        {
                            Console.WriteLine("SUMA");
                            Console.ResetColor();
                            Console.Write("Ingrese el 1er numero: ");
                            a = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Ingrese el 2do numero: ");
                            b = Convert.ToInt64(Console.ReadLine());
                            Console.Write($"La SUMA de {a} + {b} es ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{ calculadora.Sumar(a, b)}\n");
                            Console.ResetColor();
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("RESTA");
                            Console.ResetColor();
                            Console.Write("Ingrese el 1er numero: ");
                            a = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Ingrese el 2do numero: ");
                            b = Convert.ToInt64(Console.ReadLine());
                            Console.Write($"La RESTA de {a} - {b} es ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{calculadora.Restar(a, b)}\n");
                            Console.ResetColor();
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("MULTIPLICACION");
                            Console.ResetColor();
                            Console.Write("Ingrese el 1er numero: ");
                            a = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Ingrese el 2do numero: ");
                            b = Convert.ToInt16(Console.ReadLine());
                            Console.Write($"La MULTIPLICACION de {a} X {b} es ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{calculadora.Multiplicar(a, b)}\n");
                            Console.ResetColor();
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("DIVISION");
                            Console.ResetColor();
                            Console.Write("Ingrese el 1er numero: ");
                            a = Convert.ToInt16(Console.ReadLine());

                            do
                            {
                                Console.Write("Ingrese el 2do numero (distinto de cero): ");
                                b = Convert.ToInt16(Console.ReadLine());

                                if (b == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("El segundo número no puede ser cero. Por favor, ingrese un valor distinto de cero.");
                                    Console.ResetColor();
                                }
                            } while (b == 0);

                            try
                            {
                                Console.Write($"La DIVISION de {a} / {b} es ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{calculadora.Dividir(a, b)}\n");
                                Console.ResetColor();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;

                    case 5:
                        {
                            Console.WriteLine("NUMERO MAYOR DE UNA LISTA");
                            Console.Write("Generando numeros aleatorios");
                            for (int i = 0; i<3; i++)
                            {
                                Console.Write('.');
                                Thread.Sleep(500);
                            }
                            // General los numeros aleatorios
                            for (int i = 0; i < 10; i++)
                                nums.Add(random.Next(1, 500));

                            Console.ResetColor();
                            // Muestra los numeros aleatorios
                            Console.Write("\nLa lista de numeros aleatorios es: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < 10; i++)
                                Console.Write($"{nums[i]} ");

                            // Muestra el mayor
                            aux = nums[0];
                            for (int i = 0;i < 10; i++)
                            {
                                if (aux <  nums[i]) { aux = nums[i]; }
                            }
                            Console.ResetColor();
                            Console.Write("\nEl numero mayor es ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{aux}");

                            // Vacia la lista
                            nums.Clear();
                        } break;

                    case 6:
                        {
                            Console.WriteLine("NUMERO MENOR DE UNA LISTA");
                            Console.Write("Generando numeros aleatorios");
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write('.');
                                Thread.Sleep(500);
                            }
                            // General los numeros aleatorios
                            for (int i = 0; i < 10; i++)
                                nums.Add(random.Next(1, 500));

                            Console.ResetColor();
                            // Muestra los numeros aleatorios
                            Console.Write("\nLa lista de numeros aleatorios es: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < 10; i++)
                                Console.Write($"{nums[i]} ");

                            // Muestra el mayor
                            aux = nums[0];
                            for (int i = 0; i < 10; i++)
                            {
                                if (aux > nums[i]) { aux = nums[i]; }
                            }
                            Console.ResetColor();
                            Console.Write("\nEl numero menor es ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{aux}");

                            // Vacia la lista
                            nums.Clear();
                        }
                        break;

                    case 7:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nByeeee!");
                            Console.WriteLine("Programa hecho por Cristopher Vanegas...\n\n");
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
                Console.WriteLine("\nPresione la tecla enter...");
                Console.ReadLine();
            } while (opt != 7);
        }
    }
}
