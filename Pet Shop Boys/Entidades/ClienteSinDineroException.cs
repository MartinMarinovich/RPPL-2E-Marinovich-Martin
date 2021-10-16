using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteSinDineroException : Exception
    {


        public override string Message
        {
            get
            {
                return "El cliente no posee dinero para esta compra";
            }
        }

    }

}
