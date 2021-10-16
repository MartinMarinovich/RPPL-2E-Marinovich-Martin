using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Compra
    {
        int codigo;
        static int primerCodigo;
        Cliente comprador;
        float monto;
        List<Producto> listaDeProductos;
        Envio envio;
        /// <summary>
        /// Constructor de la clase compra, se compone de un objeto ciente, float monto de dinero de la compra y lista de objetos tipo producto
        /// </summary>
        /// <param name="comprador"></param>
        /// <param name="monto"></param>
        /// <param name="listaDeProductos"></param>
        public Compra(Cliente comprador, float monto, List<Producto> listaDeProductos, Envio envio)
        {
            Codigo = primerCodigo;
            primerCodigo++;
            Comprador = comprador;
            Monto = monto;
            Carrito = listaDeProductos;
            EnvioCompra = envio;
        }

        /// <summary>
        /// Constructor estatico que instancia por unica vez el primer codigo de la compra y luego se va incrementando
        /// </summary>
        static Compra()
        {
            primerCodigo = 500;
        }

        /// <summary>
        /// Propiedad Codigo, identificador de tipo int de la compra, es autoincremental no se puede asignar
        /// </summary>
        private int Codigo
        {
            set
            {
                if (value >=500)
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
        /// Propiedad Carrito, representa la propiedad de la lista de productos que componen a la clase 
        /// </summary>
        public List<Producto> Carrito
        {
            set
            {
                if (value != null)
                {
                    this.listaDeProductos = value;
                }
            }

            get
            {
                return this.listaDeProductos;
            }
        }
        /// <summary>
        /// Propiedad comprador que representa al objeto comprador de la clase
        /// </summary>
        public Cliente Comprador
        {
            set
            {
                if (value != null)
                {
                    this.comprador = value;
                }
            }

            get
            {
                return this.comprador;
            }
        }
        /// <summary>
        /// Propiedad monto de dinero del cliente
        /// </summary>
        public float Monto
        {
            set
            {
                if (value > 0)
                {
                    this.monto = value;
                }
            }

            get
            {
                return this.monto;
            }
        }

        public Envio EnvioCompra
        {
            set
            {
                if (value != null)
                {
                    this.envio = value;
                }
            }

            get
            {
                return this.envio;
            }
        }


        /// <summary>
        /// Metodo protegido de la clase compra que retorna los datos que conforman a la compra
        /// </summary>
        /// <returns>Los datos de la clase compra coomo string</returns>
        public string Datos()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0,-12} {1,8} {2,12}\n", this.Codigo.ToString(),this.Monto.ToString(),this.Comprador.DatosCliente(),(string)this.envio);
           
            return sb.ToString();

        }
        /// <summary>
        /// Metodo propio de la clase  compra para mostrar los datos del atributo carrito que contiene la lista de productos
        /// </summary>
        /// <returns>Los datos de la lista de productos como string</returns>
        public string MostrarCarrito()
        {
            StringBuilder sb = new StringBuilder();
            string formato = string.Empty;


            foreach (Producto item in this.Carrito)
            {
                sb.AppendLine("\n");
                sb.AppendFormat("\n{0,-12}{1,10}{2,17}\n", item.Tipo, item.Descripcion, item.Precio);
              
            }

            return sb.ToString();
        }
    }
}
