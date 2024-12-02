using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SingleResponsibilityPrinciple
    {
        // Mala practica: Una clase maneja varias responsabilidades 
        public class Reporte 
        { 
            public void GenerarReporte()
            {
                Console.WriteLine("Generando reporte...");
            }
            public void EnviaPorCorreo(string correo)
            {
                Console.WriteLine($"Enviando reporte a {correo}");
            }
        }

        public class GeneradorDeReporte
        {
            public void GenerarReporte()
            {
                Console.WriteLine("Generando reporte...");
            }
        }
        public class EnviadorDeCorreo
        {
            public void EnviaPorCorreo(string correo)
            {
                Console.WriteLine($"Enviando reporte a {correo}");
            }
        }
    }
}
