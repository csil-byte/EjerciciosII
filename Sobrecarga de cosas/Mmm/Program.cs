using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmm
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Saludo(string nombre_ty)
            {
                return "Hola, tu nombre es " + nombre_ty + ".";
            }

            static string Saludo(string nombre, string apellido)
            {

                return Saludo(nombre + " " + apellido);

            }

            public static void Print()
            {
                Console.WriteLine(Saludo("Cecilia"));
                Console.ReadKey();
            }

            
        }
    }
}
