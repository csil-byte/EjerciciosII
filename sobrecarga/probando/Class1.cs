
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace probando
{
    public class Class1
    {
        
        public string Saludo(string nombre_ty)
        {
            return "Hola, tu nombre es " + nombre_ty + ".";
        }

        public string Saludo(string nombre, string apellido)
        {
            
            return Saludo(nombre + " " + apellido);
                
        }

        public void Print()
        {
            Console.WriteLine(Saludo("Cecilia"));
            Console.ReadKey();
        }
        
    }
}
