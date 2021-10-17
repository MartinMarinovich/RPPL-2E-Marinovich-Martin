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
                return "La compra ha sido cancelada debido a que el cliente no posee tanto dinero, realicela nuevamente";
            }
        }

    }

}
