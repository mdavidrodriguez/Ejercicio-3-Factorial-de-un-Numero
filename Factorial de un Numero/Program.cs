using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_de_un_Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo del Fatorial de un numero");
            Console.WriteLine("Digite un numero: ");
            int num = int.Parse(Console.ReadLine());
            int Factor = 1;
            for (int i = 1; i < num + 1; i++)
                 Factor*= i;
            Console.WriteLine("El factorial del numero es: " + Factor );
            Console.ReadLine();      
        }
    }
}
