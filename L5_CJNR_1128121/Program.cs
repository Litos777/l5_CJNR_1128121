using System;

namespace L5_CJNR_1128121_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio No. 1");
            Console.WriteLine("Ingrese un numero entero");
            int gg;
            gg = Convert.ToInt16(Console.ReadLine());
            if (gg > 0)
            {
                Console.WriteLine("Es un numero positivo");
            }
            else if (gg < 0)
            {
                Console.WriteLine("Es un numero negativo");
            }
            else if (gg == 0)
            {
                Console.WriteLine("El numero es igual a 0");
            }
       

        }
    }
}
