using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        SingleResponsibilityPrinciple singleResponsibilityPrinciple;
        OpenClosedPrinciple openClosedPrinciple;
        LiskovSubstitutionPrinciple liskovSubstitutionPrinciple;
        InterfaceSegregatioPrinciple interfaceSegregatioPrinciple;
        DependencyInversionPrinciple dependencyInversionPrinciple;

        // Ejemplo de Code Challenge 
        // Ejemplo 1: Validar paréntesis balanceados
        public class Validator
        {
            public static bool EsBalanceado(string input)
            {
                Stack<char> stack = new Stack<char>();
                foreach (char c in input)
                {
                    if (c == '(')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')')
                    {
                        if (stack.Count == 0)
                        {
                            return false;
                        }
                        stack.Pop();
                    }
                }
                return stack.Count == 0;
            }
        }
        // Ejemplo de Code Challenge 
        // Ejemplo 2: Encontrar el número único en un arreglo
        public class UniqueNumber
        {
            public static int EncontrarUnico(int[] numeros)
            {
                int resultado = 0;
                foreach (int numero in numeros)
                {
                    resultado ^= numero; // Operación XOR
                }
                return resultado;
            }
        }

        // Ejemplo de Code Challenge 
        // Ejemplo 3: Ejemplo de palíndromo
        public class PalindromeCheker
        {
            public static bool EsPalindromo(string palabra)
            {
                int inicio = 0, fin = palabra.Length - 1;

                while (inicio < fin)
                {
                    if (palabra[inicio] != palabra[fin])
                        return false;
                    inicio++;
                    fin--;
                }
                return true;
            }
        }

        // Ejemplo de Code Challenge 
        // Ejemplo 4: Principio de FIBONACCI
        public class Fibonacci
        {
            public static int Calcular(int n)
            {
                if (n <= 1)
                    return n;
                return Calcular(n - 1) + Calcular(n - 2);
            }
        }

        static Task OperacionLarga()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Iniciando operación larga...");
                Task.Delay(3000).Wait(); // Simula una operación larga
                Console.WriteLine("Operación larga completada.");
            });
        }

        //static void Main()
        //{
        //    //Prueba 1 de Consola
        //    Console.WriteLine("Hello World!");
        //    //Prueba 2 de Consola
        //    Console.WriteLine(Validator.EsBalanceado("((()))"));  // True
        //    Console.WriteLine(Validator.EsBalanceado("(()))"));   // False
        //    Console.WriteLine(Validator.EsBalanceado("(()())"));  // True
        //    //Prueba 3 de Consola
        //    int[] numeros = { 2, 3, 2, 4, 4 };
        //    Console.WriteLine(UniqueNumber.EncontrarUnico(numeros)); // 3
        //    //Prueba 4 de Consola
        //    Console.WriteLine(PalindromeCheker.EsPalindromo("radar"));  // True
        //    Console.WriteLine(PalindromeCheker.EsPalindromo("hello"));  // False
        //    Console.WriteLine(PalindromeCheker.EsPalindromo("level"));  // True
        //    //Prueba 5 de Consola
        //    SingleResponsibilityPrinciple.Reporte reporte = new SingleResponsibilityPrinciple.Reporte();
        //    reporte.GenerarReporte();
        //    reporte.EnviaPorCorreo("omaraurelio1@gmail.com");
        //    //Prueba 6 de Consola
        //    SingleResponsibilityPrinciple.GeneradorDeReporte generadorDeReporte = new SingleResponsibilityPrinciple.GeneradorDeReporte();
        //    generadorDeReporte.GenerarReporte();
        //    //Prueba 7 de Consola
        //    SingleResponsibilityPrinciple.EnviadorDeCorreo enviadorDeCorreo = new SingleResponsibilityPrinciple.EnviadorDeCorreo();
        //    enviadorDeCorreo.EnviaPorCorreo("omaraurelio1@msw.com.mx");
        //    //Prueba 8 de Consola
        //    OpenClosedPrinciple.Calculadora calculadora = new OpenClosedPrinciple.Calculadora();
        //    Console.WriteLine(calculadora.Calcular(5, 3, "sumar")); // 8
        //    Console.WriteLine(calculadora.Calcular(5, 3, "restar")); // 2
        //    Console.WriteLine(calculadora.Calcular(5, 3, "multiplicar")); // 15
        //    Console.WriteLine(calculadora.Calcular(6, 3, "dividir")); // 2
        //    //Prueba 9 de Consola
        //    OpenClosedPrinciple.Calculadora2 calculadora2 = new OpenClosedPrinciple.Calculadora2();
        //    Console.WriteLine(calculadora2.Calcular(5, 3, new OpenClosedPrinciple.Suma())); // 8
        //    Console.WriteLine(calculadora2.Calcular(5, 3, new OpenClosedPrinciple.Resta())); // 2
        //    Console.WriteLine(calculadora2.Calcular(5, 3, new OpenClosedPrinciple.Multiplicacion())); // 15
        //    Console.WriteLine(calculadora2.Calcular(6, 3, new OpenClosedPrinciple.Division())); // 2
        //    //Prueba 10 de Consola
        //    LiskovSubstitutionPrinciple.Animal animal = new LiskovSubstitutionPrinciple.Animal();
        //    animal.Mover();
        //    LiskovSubstitutionPrinciple.Pez pez = new LiskovSubstitutionPrinciple.Pez();
        //    //pez.Mover();
        //    LiskovSubstitutionPrinciple.Animal2 animal2 = new LiskovSubstitutionPrinciple.Animal2();
        //    animal2.Mover();
        //    LiskovSubstitutionPrinciple.Pez2 pez2 = new LiskovSubstitutionPrinciple.Pez2();
        //    pez2.Mover();
        //    //Prueba 11 de Consola
        //    InterfaceSegregatioPrinciple.Coche coche = new InterfaceSegregatioPrinciple.Coche();
        //    coche.Conducir();
        //    InterfaceSegregatioPrinciple.Avion avion = new InterfaceSegregatioPrinciple.Avion();
        //    avion.Conducir();
        //    avion.Volar();
        //    //Prueba 12 de Consola
        //    //DependencyInversionPrinciple.LectorDeArchivo lectorDeArchivo = new DependencyInversionPrinciple.LectorDeArchivo();
        //    DependencyInversionPrinciple.ProcesadorDeDatos procesadorDeDatos = new DependencyInversionPrinciple.ProcesadorDeDatos();
        //    procesadorDeDatos.Procesar("C:\\Proyectos\\RepasoNet\\prueba.txt"); // Proporcionar la ruta del archivo

        //    DependencyInversionPrinciple.ILector1 lector1 = new DependencyInversionPrinciple.LectorDeArchivo1();
        //    DependencyInversionPrinciple.ProcesadorDeDatos1 procesadorDeDatos1 = new DependencyInversionPrinciple.ProcesadorDeDatos1(lector1);
        //    procesadorDeDatos1.Procesar("C:\\Proyectos\\RepasoNet\\prueba2.txt"); // Proporcionar la ruta del archivo
        //    //Prueba 13 de Consola
        //    Console.WriteLine(Fibonacci.Calcular(10)); // 55
        //    //Prueba 14 de Consola
        //    // Llamada asíncrona usando Task
        //    Task tarea = OperacionLarga();
        //    // Continuar con otras operaciones
        //    Console.WriteLine("Ejecutando otras operaciones...");
        //    // Esperar la finalización de la tarea
        //    tarea.Wait();
        //    Console.WriteLine("Programa finalizado.");

        //}
        internal class Program1
        {
            static async Task OperacionLarga()
            {
                Console.WriteLine("Iniciando operación larga1...");
                await Task.Delay(3000); // Simula una operación larga
                Console.WriteLine("Operación larga completada1.");
            }

            static async Task Main()
            {
                //Prueba 1 de Consola
                Console.WriteLine("Hello World!");
                //Prueba 2 de Consola
                Console.WriteLine(Validator.EsBalanceado("((()))"));  // True
                Console.WriteLine(Validator.EsBalanceado("(()))"));   // False
                Console.WriteLine(Validator.EsBalanceado("(()())"));  // True
                //Prueba 3 de Consola
                int[] numeros = { 2, 3, 2, 4, 4 };
                Console.WriteLine(UniqueNumber.EncontrarUnico(numeros)); // 3
                //Prueba 4 de Consola
                Console.WriteLine(PalindromeCheker.EsPalindromo("radar"));  // True
                Console.WriteLine(PalindromeCheker.EsPalindromo("hello"));  // False
                Console.WriteLine(PalindromeCheker.EsPalindromo("level"));  // True
                //Prueba 5 de Consola
                SingleResponsibilityPrinciple.Reporte reporte = new SingleResponsibilityPrinciple.Reporte();
                reporte.GenerarReporte();
                reporte.EnviaPorCorreo("omaraurelio1@gmail.com");
                //Prueba 6 de Consola
                SingleResponsibilityPrinciple.GeneradorDeReporte generadorDeReporte = new SingleResponsibilityPrinciple.GeneradorDeReporte();
                generadorDeReporte.GenerarReporte();
                //Prueba 7 de Consola
                SingleResponsibilityPrinciple.EnviadorDeCorreo enviadorDeCorreo = new SingleResponsibilityPrinciple.EnviadorDeCorreo();
                enviadorDeCorreo.EnviaPorCorreo("omaraurelio1@msw.com.mx");
                //Prueba 8 de Consola
                OpenClosedPrinciple.Calculadora calculadora = new OpenClosedPrinciple.Calculadora();
                Console.WriteLine(calculadora.Calcular(5, 3, "sumar")); // 8
                Console.WriteLine(calculadora.Calcular(5, 3, "restar")); // 2
                Console.WriteLine(calculadora.Calcular(5, 3, "multiplicar")); // 15
                Console.WriteLine(calculadora.Calcular(6, 3, "dividir")); // 2
                //Prueba 9 de Consola
                OpenClosedPrinciple.Calculadora2 calculadora2 = new OpenClosedPrinciple.Calculadora2();
                Console.WriteLine(calculadora2.Calcular(5, 3, new OpenClosedPrinciple.Suma())); // 8
                Console.WriteLine(calculadora2.Calcular(5, 3, new OpenClosedPrinciple.Resta())); // 2
                Console.WriteLine(calculadora2.Calcular(5, 3, new OpenClosedPrinciple.Multiplicacion())); // 15
                Console.WriteLine(calculadora2.Calcular(6, 3, new OpenClosedPrinciple.Division())); // 2
                //Prueba 10 de Consola
                LiskovSubstitutionPrinciple.Animal animal = new LiskovSubstitutionPrinciple.Animal();
                animal.Mover();
                LiskovSubstitutionPrinciple.Pez pez = new LiskovSubstitutionPrinciple.Pez();
                //pez.Mover();
                LiskovSubstitutionPrinciple.Animal2 animal2 = new LiskovSubstitutionPrinciple.Animal2();
                animal2.Mover();
                LiskovSubstitutionPrinciple.Pez2 pez2 = new LiskovSubstitutionPrinciple.Pez2();
                pez2.Mover();
                //Prueba 11 de Consola
                InterfaceSegregatioPrinciple.Coche coche = new InterfaceSegregatioPrinciple.Coche();
                coche.Conducir();
                InterfaceSegregatioPrinciple.Avion avion = new InterfaceSegregatioPrinciple.Avion();
                avion.Conducir();
                avion.Volar();
                //Prueba 12 de Consola
                //DependencyInversionPrinciple.LectorDeArchivo lectorDeArchivo = new DependencyInversionPrinciple.LectorDeArchivo();
                DependencyInversionPrinciple.ProcesadorDeDatos procesadorDeDatos = new DependencyInversionPrinciple.ProcesadorDeDatos();
                procesadorDeDatos.Procesar("C:\\Proyectos\\RepasoNet\\prueba.txt"); // Proporcionar la ruta del archivo

                DependencyInversionPrinciple.ILector1 lector1 = new DependencyInversionPrinciple.LectorDeArchivo1();
                DependencyInversionPrinciple.ProcesadorDeDatos1 procesadorDeDatos1 = new DependencyInversionPrinciple.ProcesadorDeDatos1(lector1);
                procesadorDeDatos1.Procesar("C:\\Proyectos\\RepasoNet\\prueba2.txt"); // Proporcionar la ruta del archivo
                //Prueba 13 de Consola
                Console.WriteLine(Fibonacci.Calcular(10)); // 55
                //Prueba 14 de Consola
                // Llamada asíncrona usando Task
                Task tarea = OperacionLarga();
                // Continuar con otras operaciones
                Console.WriteLine("Ejecutando otras operaciones...");
                // Esperar la finalización de la tarea
                tarea.Wait();
                Console.WriteLine("Programa finalizado.");
                await OperacionLarga();
                //Prueba Commit 2
            }            
        }
    }
}
