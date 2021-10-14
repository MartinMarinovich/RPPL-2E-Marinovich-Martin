using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Usuario
    {
        string nombre;
        string apellido;
        double dni;
        float sueldo;
        string user;
        string contraseña;
    
        /// <summary>
        /// Constructor de la clase usuario que sea sus atributos nombre apellido dni sueldo usuario y contraseña
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="sueldo"></param>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        public Usuario(string nombre, string apellido, double dni,float sueldo,string usuario, string contraseña)
        {

            User = usuario;
            Contraseña = contraseña;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Salario = sueldo;
        }

        /// <summary>
        /// Propiedad string nombre valida que no sea null, lo setea y lo devuelve
        /// </summary>
        public string Nombre
        {
            set
            {
                if (Local.ValidarString(value))
                {
                    this.nombre = value;
                }
            }

            get
            {
                return this.nombre;
            }

        }

        /// <summary>
        /// Propiedad string Apellido valida que no sea null, lo setea y lo devuelve
        /// </summary>
        public string Apellido
        {
            set
            {
                if (Local.ValidarString(value))
                {
                    this.apellido = value;
                }
            }

            get
            {
                return this.apellido;
            }

        }

        /// <summary>
        /// Propiedad doubleo  Dni valida que no sea 0, lo setea y lo devuelve
        /// </summary>
        public double DNI
        {
            set
            {
                if (Local.ValidarDNI(value))
                {
                    this.dni = value;
                }
               
            }

            get
            {
                return this.dni;
            }

        }

        /// <summary>
        /// Propiedad float  Salario valida que no sea 0, lo setea y lo devuelve
        /// </summary>
        public float Salario
        {
            set
            {
                if(value >0)
                {
                    this.sueldo = value;
                }
            }

            get
            {
                return this.sueldo;
            }
        }


        /// <summary>
        /// Propiedad string Usuario para loguearse valida que no sea null, lo setea y lo devuelve
        /// </summary>
        public string User
        {
            set
            {
                if (Local.ValidarString(value))
                {
                    this.user = value;
                }else
                {
                    
                }
            }

            get
            {
                return this.user;
            }
        }

        /// <summary>
        /// Propiedad string Contraseña para loguearse valida que no sea null, lo setea y lo devuelve
        /// </summary>
        public string Contraseña
        {
            set
            {
                if(Local.ValidarString(value))
                {
                    this.contraseña = value;
                }
            }

            get
            {
                return this.contraseña;
            }
        }

        /// <summary>
        /// Firma del metodo que va a ser heredado por las clases hijas para mostrar los datos
        /// </summary>
        /// <returns>String de datos</returns>
        public abstract string Datos();

        public string DatosLogin()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}",this.Nombre);
            return sb.ToString(); 

        }
        
      
    }
}
