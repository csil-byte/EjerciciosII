using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;

        }
        private string GetMarca()
        {
            return this.marca;
        }

        private float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto producto)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(String.Format("Producto - marca {0}", producto.marca));
            stringBuilder.AppendLine(String.Format("Producto - precio {0}", producto.precio));
            stringBuilder.AppendLine(String.Format("Producto - codigo de barra {0}", producto.codigoDeBarra));

            return stringBuilder.ToString();
        }

        

    }
}
