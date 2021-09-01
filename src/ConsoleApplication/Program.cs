//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            // Itera mientras cumple mientras la cantidad de vueltas sea menor a 10000000, despues de cierta cantidad de iteraciones el valor de i vuelve a 0, 
            // Pero de todas maneras sigue iterando
            for (int i = 0; i < 10000000; i++)
            {
                string idToString = i.ToString();
                var trainFor = new Train(idToString);
                Console.WriteLine(trainFor.Count);
            }
            
            var train = new Train("test");
            // El valor de Count coincide con el ultimo valor de i del for, pero este no es 10000000
            Console.WriteLine(train.Count);

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            
            // Compara los objectos t1, t2 y t3, en todos los casos los objectos no van a ser iguales, ya que son 3 variables distintas y estas se almacenan
            // En lugares separados de la memoria, si quisiese que me mostrara que son iguales si coinciden en algun valor deberia modificar el metodo por el
            // Cual se los compara
            if(t1 == t2)
            {
                Console.WriteLine($"{t1.Id} es igual a {t2.Id}");
            }
            else
            {
                Console.WriteLine($"{t1.Id} no es igual a {t2.Id}");
            }

            if(t2 == t3)
            {
                Console.WriteLine($"{t2.Id} es igual a {t3.Id}");
            }
            else
            {
                Console.WriteLine($"{t2.Id} no es igual a {t3.Id}");
            }

            
            // train.StartEngines();
            // Console.WriteLine("Hello World!");
        }
    }
}