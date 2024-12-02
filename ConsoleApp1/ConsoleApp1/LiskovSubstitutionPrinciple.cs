using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LiskovSubstitutionPrinciple
    {
        // Mala práctica: La clase derivada no respeta el contrato de la clase base
        public class Animal
        {
            public virtual void Mover() => Console.WriteLine("El animal se mueve");
        }
        public class Pez : Animal
        {
            public override void Mover()
            {
                throw new InvalidOperationException("No se respeto el contrato"); //No respeta el contrato
            }
        }
        // Correción: Crear una interfaz para las clases derivadas  
        public class Animal2
        {
            public virtual void Mover() => Console.WriteLine("El animal se mueve");
        }
        public class Pez2 : Animal2
        {
            public override void Mover()
            {
                Console.WriteLine("El pez nada");
            }
        }
    }
}
