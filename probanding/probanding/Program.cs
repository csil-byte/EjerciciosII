using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probanding
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] numero = new int[5];
            int max = 0;
            int min = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Ingresar un número");
                numero[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine(numero);

                if (i == 0 || numero[i] > max)
                {
                    max = numero[i];

                }
                if (i == 0 || numero[i] < min)
                {
                    min = numero[i];
                }
            }
            
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();

        }       

    }
}
