using System.Text;
using static Entidades.Enumerados;

namespace Entidades
{
    public class Producto
    {
        double codigo;
        float precio;
        int cantidad;
        Eproducto tipo;
        string descripcion;

        /// <summary>
        /// Constructor de la clase producto instancia los instancia los atributos codigo, precio, cantidad, enumerador tipo y descripcion
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="tipo"></param>
        /// <param name="descripcion"></param>
        public Producto(double codigo, float precio, int cantidad, Eproducto tipo, string descripcion)
        {
            Codigo = codigo;
            Precio = precio;
            Stock = cantidad;
            Tipo = tipo;
            Descripcion = descripcion;
        }

        /// <summary>
        /// Propiedad double Codigo, valida que no sea 0 asigna y devuelve el valor
        /// </summary>

        public double Codigo
        {
            set
            {
                if (value > 0)
                {
                    this.codigo = value;
                }

            }

            get
            {
                return this.codigo;
            }
        }

        /// <summary>
        /// Propiedad floar Precio, valida que no sea 0 asigna y devuelve el valor
        /// </summary>
        public float Precio
        {
            set
            {
                if (value > 0)
                {
                    this.precio = value;
                }

            }

            get
            {
                return this.precio;
            }
        }

        /// <summary>
        /// Propiedad enumerador de  Tipos, asigna y devuelve el valor
        /// </summary>
        public Eproducto Tipo
        {
            set
            {
                this.tipo = value;

            }

            get
            {
                return this.tipo;
            }
        }

        /// <summary>
        /// Propiedad int  de  Stock, valida que no sea 0 asigna y devuelve el valor
        /// </summary>
        public int Stock
        {
            set
            {
                if(value>=0)
                {
                    this.cantidad = value;
                }

            }

            get
            {
                return this.cantidad;
            }
        }

        /// <summary>
        /// Propiedad string Descripcion, valida que no sea null o vacio asigna y devuelve el valor
        /// </summary>
        public string Descripcion
        {
            set
            {
                if (Local.ValidarString(value))
                {
                    this.descripcion = value;
                }

            }

            get
            {
                return this.descripcion;
            }
        }

        /// <summary>
        /// Metodo publico de la clase producto que devuelve los atributos de la clase como string
        /// </summary>
        /// <returns>String de datos</returns>
        public string DatosProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendJoin("                   ", Codigo, Tipo, Descripcion, Precio, Stock);
            return sb.ToString();
        }
        

        public string DatosParaVenta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendJoin("                 ", Codigo, Tipo, Descripcion, Precio);

            return sb.ToString();
        }
    }
}
