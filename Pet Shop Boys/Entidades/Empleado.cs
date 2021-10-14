using System.Text;

namespace Entidades
{
    public class Empleado : Usuario
    {
        int idEmpleado;
        static int primerId;
        /// <summary>
        /// Constructor estatico que instacia la variable primer ID por unica vez 
        /// </summary>
        static Empleado()
        {
            primerId = 1;
        }

        /// <summary>
        /// Constructor de la clase Empleado  que utiliza la sobre carga del constructor de la clase padre Usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="DNI"></param>
        /// <param name="sueldo"></param>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>

        public Empleado(string nombre, string apellido, double DNI, float sueldo, string usuario, string contraseña) : base(nombre, apellido, DNI, sueldo, usuario, contraseña)
        {
            Id = primerId;
            primerId++;
        }


        /// <summary>
        /// Propiedad que setea y devuelve el ID del empleado
        /// </summary>
        public int Id
        {
            set
            {
                this.idEmpleado = value;
            }

            get
            {
                return this.idEmpleado;
            }
        }

        /// <summary>
        /// Metodo de la clase padre Usuario al que se le hace un override y se modifica para devolver los datos del empleado
        /// </summary>
        /// <returns></returns>
        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{ this.Id}     {this.Nombre}        {this.Apellido}                {this.DNI}                   { this.Salario}");
            return sb.ToString();

        }

        /// <summary>
        /// Metodo estatico el cual recibe un empleado y los nuevos datos que se le asignaran, valid que no esten vacios y se los asigna como nuevos atributos
        /// </summary>
        /// <param name="emp"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="DNI"></param>
        /// <param name="sueldo"></param>
        /// <returns>Si se puedo asignar, false si no</returns>
        public static bool MoficarEmpleado(Empleado emp, string nombre, string apellido, double DNI, float sueldo)
        {

            if (Local.ValidarString(nombre) && Local.ValidarString(apellido) && Local.ValidarDNI(DNI) && !float.IsNaN(sueldo))
            {
                emp.Nombre = nombre;
                emp.Apellido = apellido;
                emp.DNI = DNI;

                return true;
            }
            return false;

        }

    }
}
