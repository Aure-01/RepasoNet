using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InterfaceSegregatioPrinciple
    {
        // Mala práctica: Una interfaz genérica con métodos innecesarios
        public interface IVehiculo
        {
            void Conducir();
            void Volar();
        }
        // Corrección: Dividir la interfaz
        public interface IVehiculoTerrestre
        {
            void Conducir();
        }
        public interface IVehiculoAereo
        {
            void Volar();
        }
        public class Coche : IVehiculoTerrestre
        {
            public void Conducir() => Console.WriteLine("Conduciendo el coche...");
        }
        public class Avion : IVehiculoAereo, IVehiculoTerrestre
        {
            public void Conducir() => Console.WriteLine("Rodando en pista...");
            public void Volar() => Console.WriteLine("Volando el avión...");
        }
    }
}
