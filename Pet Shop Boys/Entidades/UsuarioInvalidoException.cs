using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInvalidoException : Exception
    {
        public UsuarioInvalidoException()
        {

        }

        public override string Message
        {

            get
            {
                return "Error al loguear usuario, creedenciales invalidas";
            }
        }

    }
}
