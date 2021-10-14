using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Administrador : Usuario
    {
        int idAdministrador;
        static int primerId;


        /// <summary>
        /// Constructor estatico que instancia por unica vez el primer ID del administrador y luego se va incrementando
        /// </summary>
        static Administrador()
        {
            primerId = 100;
        }

        /// <summary>
        /// Constructor que realiza la sobre carga del constructor e instancia con el   de clase padre USUARIO
        /// </summary>
        /// <param name="nombreAdmin"></param>
        /// <param name="apellidoAdmin"></param>
        /// <param name="dni"></param>
        /// <param name="sueldo"></param>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>

        public Administrador(string nombre, string apellido, double DNI, float sueldo, string usuario, string contraseña) : base(nombre, apellido, DNI, sueldo, usuario, contraseña)
        {
            ID = primerId;
            primerId++;
        }

        /// <summary>
        /// Propiedad del Id unico 
        /// </summary>
        public int ID
        {
            set
            {
                this.idAdministrador = value;
            }

            get
            {
                return this.idAdministrador;
            }
        }
        /// <summary>
        /// Metodo heredado y modificado de la clase USUARIO el cual retorna los datos propios de la clase
        /// </summary>
        /// <returns></returns>
        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{ID}     {Nombre}        {Apellido}                {DNI}                   {Salario}");
            return sb.ToString();
        }

    }

}

