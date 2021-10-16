using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoStockException : Exception
    {
       
        public override string Message
        {
            get
            {
                return "No se puede agregar esa cantidad de producto";
            }
        }
    }
}
