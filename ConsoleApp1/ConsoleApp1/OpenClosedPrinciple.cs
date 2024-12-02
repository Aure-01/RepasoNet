using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OpenClosedPrinciple
    {
        // Mala práctica: Modificar una clase existente para agregar funcionalidad
        public class Calculadora
        {
            public int Calcular(int a, int b, string operacion)
            {
                if (operacion == "sumar") return a + b;
                else if (operacion == "restar") return a - b;
                else if (operacion == "multiplicar") return a * b;
                else if (operacion == "dividir") return a / b;
                else throw new ArgumentException("Operación no soportada");
            }
        }
        // Corrección: Usar polimorfismo para extender funcionalidades
        public interface IOperacion
        {
            int Operar(int a, int b);
        }
        public class Suma : IOperacion
        {
            public int Operar(int a, int b)
            {
                return a + b;
            }
        }
        public class Resta : IOperacion
        {
            public int Operar(int a, int b)
            {
                return a - b;
            }
        }
        public class Multiplicacion : IOperacion
        {
            public int Operar(int a, int b)
            {
                return a * b;
            }
        }
        public class Division : IOperacion
        {
            public int Operar(int a, int b)
            {
                return a / b;
            }
        }
        public class Calculadora2
        {
            public int Calcular(int a, int b, IOperacion operacion)
            {
                return operacion.Operar(a, b);
            }
        }
    }
}
