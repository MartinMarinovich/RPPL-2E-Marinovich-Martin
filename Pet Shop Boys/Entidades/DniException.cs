using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DniException : Exception
    {
        public DniException()
        {

        }

        public override string Message { get { return "Error: Ingreso un DNI  invalido"; }}

    }
}
