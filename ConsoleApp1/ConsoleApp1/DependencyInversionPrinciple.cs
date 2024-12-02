using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DependencyInversionPrinciple
    {
        // Mala práctica: Dependencia directa en la implementación
        public class LectorDeArchivo
        {
            public string LeerArchivo(string ruta)
            {
                return System.IO.File.ReadAllText(ruta);
            }
        }

        public class ProcesadorDeDatos
        {
            private readonly LectorDeArchivo lector;

            public ProcesadorDeDatos()
            {
                lector = new LectorDeArchivo();
            }

            public void Procesar(string ruta)
            {
                string contenido = lector.LeerArchivo(ruta);
                Console.WriteLine($"Procesando: {contenido}");
            }
        }

        // Corrección: Usar abstracciones (interfaces)
        public interface ILector1
        {
            string Leer(string ruta);
        }

        public class LectorDeArchivo1 : ILector1
        {
            public string Leer(string ruta) => System.IO.File.ReadAllText(ruta);
        }

        public class ProcesadorDeDatos1
        {
            private readonly ILector1 lector;

            public ProcesadorDeDatos1(ILector1 lector)
            {
                this.lector = lector;
            }

            public void Procesar(string ruta)
            {
                string contenido = lector.Leer(ruta);
                Console.WriteLine($"Procesando: {contenido}");
            }
        }
    }
}
