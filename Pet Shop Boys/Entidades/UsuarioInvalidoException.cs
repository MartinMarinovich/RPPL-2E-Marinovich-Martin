using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInvalidoException : Exception
    {
      

        /// <summary>
        /// Propiedad Message heredada de exception la sobrescribimos para personalizar el mensaje
        /// </summary>
        public override string Message
        {

            get
            {
                return "Error al loguear usuario, creedenciales invalidas";
            }
        }

    }
}
