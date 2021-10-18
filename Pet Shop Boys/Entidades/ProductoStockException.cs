using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoStockException : Exception
    {

        /// <summary>
        /// Propiedad Message heredada de exception la sobrescribimos para personalizar el mensaje
        /// </summary>
        public override string Message
        {
            get
            {
                return "No se puede agregar esa cantidad de producto";
            }
        }
    }
}
