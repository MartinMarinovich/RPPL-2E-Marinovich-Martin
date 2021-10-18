using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Entidades.Enumerados;

namespace Entidades
{
    public static class Local
    {
        static string Nombre;
        static string Direcion;
        static double Cuit;
        static List<Producto> Inventario;
        static Stack<Cliente> Clientes;
        static List<Usuario> Personal;
        static Queue<Compra> ListaDeVentas;

        /// <summary>
        /// Constructor estatico de la clase local que instancia todas las listas de objetos que utiliza la aplicacion
        /// posee dentro tres metodos propios de la clase para pre cargar listas al iniciar el programa
        /// </summary>
        static Local()
        {
            Nombre = "Pet Shop Boys Store";
            Direcion = "Av.Mitre 150";
            Cuit = 30712535438;

            Personal = new List<Usuario>();
            Inventario = new List<Producto>();
            ListaDeVentas = new Queue<Compra>();
            Clientes = new Stack<Cliente>();

            HardcodearDatosInciales();
            HardcodearProductos();
            HardocdearClientes();
            HardcodearVentas();
        }




        /// <summary>
        /// Propiedad estatica de la Lista de usuarios, valida que no sea null setea y devuelve el atributo
        /// </summary>
        public static List<Usuario> Nomina
        {
            set
            {
                if (Personal != null)
                {
                    Personal = value;
                }

            }

            get
            {
                return Personal;
            }

        }

        /// <summary>
        /// Propiedad estatica de la Lista de Stock, valida que no sea null setea y devuelve el atributo
        /// </summary>
        public static List<Producto> Stock
        {
            set
            {
                if (value != null)
                {
                    Inventario = value;
                }
            }

            get
            {
                return Inventario;
            }

        }
        /// <summary>
        /// Propiedad estatica de la Lista de Compras, valida que no sea null setea y devuelve el atributo
        /// </summary>
        public static Queue<Compra> Ventas
        {
            set
            {
                if (value != null)
                {
                    ListaDeVentas = value;
                }
            }

            get
            {
                return ListaDeVentas;
            }

        }
        /// <summary>
        /// Propiedad estatica de la Lista de Clientes, valida que no sea null setea y devuelve el atributo
        /// </summary>
        public static Stack<Cliente> Clientela
        {
            set
            {
                if (value != null)
                {
                    Clientes = value;
                }
            }

            get
            {
                return Clientes;
            }

        }

        /// <summary>
        /// Metodo publico de validacion de string de la clase Local devuelve true si es string valido, false si no
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool ValidarString(string texto)
        {
            bool result = true;

            if (!string.IsNullOrEmpty(texto) && texto.Length > 2 && texto.Length < 20)
            {
                foreach (char item in texto)
                {
                    result = char.IsLetter(item);
                }


                return result;
            }


            return false;
        }

        /// <summary>
        /// Metodo publico de validacion de string numerico de la clase Local devuelve true si es string valido, false si no
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>True or false</returns>
        public static bool ValidarStringNumerico(string texto)
        {
            bool result = true;

            if (!string.IsNullOrEmpty(texto) && texto.Length < 9999999)
            {
                foreach (char item in texto)
                {
                    result = char.IsDigit(item);
                }


                return result;
            }


            return false;
        }

        /// <summary>
        /// Metodo publico de validacion de double DNI de la clase Local devuelve true si es un double valido, false si no
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        public static bool ValidarDNI(double DNI)
        {
            char[] arrayDni = null;
            string aux = "";
            bool result = false;

            aux = DNI.ToString();
            arrayDni = aux.ToCharArray();

            if (arrayDni[1] != 0 && (arrayDni.Length == 7 || arrayDni.Length == 8))
            {
                for (int i = 0; i < arrayDni.Length; i++)
                {
                    if (char.IsDigit(arrayDni[i]))
                    {
                        result = true;
                    }
                }


            }
            return result;
        }
        /// <summary>
        /// Metodo estatico privado que solo se utiliza para pre cargar la lista de usuarios al inciar l programa, la lista contiene empleados y administradores
        /// </summary>
        private static void HardcodearDatosInciales()
        {
            List<Usuario> hardcodeList = new List<Usuario> {
                new Empleado("Carlos","Catson",24244298,33875,"Saruman","Killhobits"),
                new Empleado("Martin", "Perez", 24342429, 24500,"Obiwan","Kenobi"),
                new Empleado("Fabricio", "Rodriguez",39911560,60000,"Casimiro","Miranda"),
                new Administrador("Lucas", "Bogdan", 43733854, 40000,"Admin","Root"),
                new Administrador("Maria", "Pardem", 44295202, 90000,"Sudo","Suuu"),
                new Administrador("Rodrigo", "Parsein", 23991590, 200000,"Notienesentido","Keapaso"),
                new Empleado("Patricio", "Arizona", 26544678, 25000,"Locoart123","Jojo"),
                new Empleado("Federico", "Bredels", 33789821, 25000,"Abcd","1234"),
                new Empleado("Alma", "Fernandez", 01247896, 25000,"Usuario","Contraseña"),
                new Empleado("Mariana", "Lopez", 33689754, 25000,"Lord","Voldemort"),
                new Empleado("Mario", "Stein", 21789321, 25000,"Finolli","Finolli"),

            };


            foreach (Usuario item in hardcodeList)
            {
                Personal.Add(item);
            }

        }

        /// <summary>
        /// Metodo estatico privado que solo se utiliza para pre cargar la lista de Productos al inciar al programa, la lista contiene objetos de tipo producto
        /// </summary>
        private static void HardcodearProductos()
        {
            List<Producto> productosHarcode = new List<Producto> {
                new Producto(3001,30,6,Eproducto.Cepillo,"Fino"),
                new Producto(3006,500,100,Eproducto.Alimento,"Perro"),
                new Producto(3007,700,100,Eproducto.Alimento,"Gato"),
                new Producto(4008,1000,10,Eproducto.Vacuna,"Antirrabica"),
                new Producto(2002,65,34,Eproducto.Golosina,"Dentasticks"),
                new Producto(2003,62,34,Eproducto.Golosina,"Carne"),
                new Producto(3008,20,15,Eproducto.Antiparasitario,"Generico")
            };


            foreach (Producto item in productosHarcode)
            {
                Stock.Add(item);
            }

        }


        private static void HardcodearVentas()
        {

            List<Compra> ventasHardcode = new List<Compra> {
                new Compra(new Cliente("Fabricio","Rodriguez",42333560),3000,Local.Stock.GetRange(0,2),new Envio(500,Evehiculo.Miniflete,30)),
                new Compra(new Cliente("Martin", "Martinez",40033560),600,Local.Stock.GetRange(1,2),new Envio(1500,Evehiculo.Miniflete,30)),
                new Compra(new Cliente("Juan", "Rodriguez",21033560),1500,Local.Stock.GetRange(3,4),new Envio(2000,Evehiculo.Motocicleta,12)),
                new Compra(new Cliente("Pedro","Parcere",31333560),2500,Local.Stock.GetRange(2,5),new Envio(800,Evehiculo.Motocicleta,11)),
            };


            foreach (Compra item in ventasHardcode)
            {
                Ventas.Enqueue(item);
            }

        }
        /// <summary>
        /// Metodo estatico privado que solo se utiliza para pre cargar la lista de Clientes al inciar al programa, la lista contiene objetos de tipo cliente
        /// </summary>
        private static void HardocdearClientes()
        {
            List<Cliente> clientesHardcode = new List<Cliente>
               {
                    new Cliente("Fabricio","Rodriguez",42333560),
                    new Cliente("Martin", "Martinez",40033560),
                    new Cliente("Juan", "Rodriguez",21033560),
                    new Cliente("Pedro","Parcere",31333560)
               };

            foreach (Cliente item in clientesHardcode)
            {
                Clientela.Push(item);
            }
        }


        /// <summary>
        /// Metodo publico y estatico de la clase que se utiliza unicamente para loguear el usuario al sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        public static Usuario LoguearUsuario(string usuario, string contraseña)
        {
            Usuario auxUsuario = null;

            if (ValidarString(usuario) && ValidarString(contraseña))
            {
                foreach (Usuario item in Local.Nomina)
                {
                    if (item.Contraseña == contraseña && item.User == usuario)
                    {
                        auxUsuario = item;
                        return auxUsuario;
                    }

                }
            }
            if (auxUsuario == null)
            {
                UsuarioInvalidoException usuarioException = new UsuarioInvalidoException();
                throw usuarioException;
            }

            return null;
        }
        /// <summary>
        /// Metodo por el cual calculamos el envio para generar la compra, toma por referencia un cliente y la lista de los productos,
        /// en base a ello se calcula el monto y el tipo de transporte
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="listaDeProductos"></param>
        /// <returns>Envio</returns>

        public static Envio AsignarEnvio(Cliente cliente, List<Producto> listaDeProductos)
        {
            Envio auxEnvio;
            Evehiculo auxVehiculo;
            int cantProductos = 0;
            float montoDelEnvio = 0;
            cantProductos = 0;
            auxVehiculo = Evehiculo.Motocicleta;

            foreach (Producto item in listaDeProductos)
            {
                cantProductos = cantProductos + item.Stock;
            }

            if (cantProductos < 4)
            {
                montoDelEnvio = 35 * cliente.Distancia;
            }
            else
            {
                montoDelEnvio = 80 * cliente.Distancia;
                auxVehiculo = Evehiculo.Miniflete;
            }

            auxEnvio = new Envio(montoDelEnvio, auxVehiculo, cliente.Distancia);

            if (auxEnvio != null)
            {
                return auxEnvio;
            }

            return null;
        }

        /// <summary>
        /// Metodo por el que descontamos stock de un producto determinado, recibe el indice donde esta el producto y la cantidad a restar
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="cantPedido"></param>
        /// <returns>boolean</returns>
        public static bool DescontarStock(int indice, int cantPedido)
        {
            if (indice >= 0 && cantPedido > 0)
            {
                Local.Stock[indice].Stock = Local.Stock[indice].Stock - cantPedido;
                return true;
            }

            return false;

        }
        /// <summary>
        /// Metodo por el cual recibimos un cliente por paramentro, la cantidad de dinero acumulado de los productos y el costo del envio,
        /// si el cliente dispone de dinero lo resta, si intentar restarle hasta un numero negativo devuelve una excepcion el seter del atributo
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="montoDeProductos"></param>
        /// <param name="costoDelEnvio"></param>
        public static void DescontarDinero(Cliente cliente, float montoDeProductos, double costoDelEnvio)
        {
            double total = montoDeProductos + costoDelEnvio;

            if (montoDeProductos > 0)
            {

                cliente.Dinero = cliente.Dinero - total;

            }
        }

        /// <summary>
        /// Metodo por el cual agregamos un producto a una lista devolviendolo, recibimos una cantidad para asignar al stock como referencia de cuanto hay y el string para buscar
        // los datos del producto
        /// </summary>
        /// <param name="cant"></param>
        /// <param name="producto"></param>
        /// <returns>Producto</returns>
        public static Producto AgregarProducto(int cant, string producto)
        {
            Producto auxProducto = null;
            int stockProducto = 0;
            int indice = 0;
            bool descontarSotck = false;

            if (cant > 0)
            {

                foreach (Producto item in Local.Stock)
                {
                    if (item.DatosProducto() == producto)
                    {
                        stockProducto = item.Stock;
                        indice = Local.Stock.IndexOf(item);
                        descontarSotck = DescontarStock(indice, cant);

                        if (descontarSotck)
                        {
                            auxProducto = new Producto(item.Codigo, item.Precio, cant, item.Tipo, item.Descripcion);
                            return auxProducto;
                        }
                    }
                }

            }
            return null;
        }

        /// <summary>
        /// Recibe una compra por parametro, transforma y formatea los datos en string y genera un txt con los datos pasados a string
        /// </summary>
        /// <param name="compra"></param>
        /// <returns>boolean</returns>
        public static bool ExportarTicketCompra(Compra compra)
        {
            StringBuilder sb = new StringBuilder();
            StreamWriter escritor = new StreamWriter("TicketCompra.txt");

            string datosComprador = string.Format("{0,-10}{1,6}{2,9}\n", compra.Comprador.Nombre, compra.Comprador.Apellido, compra.Comprador.DNI);
            string datosLocal = string.Format("{0,-12}\n\nDireccion: {1,2}\nCuit:{2,9}\n", Nombre, Direcion, Cuit.ToString());
            string headerCompra = string.Format("{0,-8}{1,6}  {2,8}{3,8}\n", "Tipo","Descripcion","Cantidad","Precio");
            string headerCliente = string.Format("{0,-7}{1,3}{2,9}\n","Nombre","Apellido","NRº DNI");
            string envio = string.Format("ENVIO: {0,-7} ${1,3}\n", compra.EnvioCompra.Transporte, compra.EnvioCompra.Precio);
            sb.AppendLine(datosLocal);
            sb.AppendLine(headerCliente);
            sb.AppendLine(datosComprador);
            sb.AppendLine(headerCompra);

            foreach (Producto item in compra.Carrito)
            {
                string datosCompra = string.Format("{0,-8}{1,6}{2,8}  {3,8}\n", item.Tipo, item.Descripcion, item.Stock, item.Precio);
                sb.AppendLine(datosCompra);
            }

            sb.AppendLine(envio);
            sb.AppendLine("MONTO TOTAL: $" +compra.Monto.ToString());

            escritor.WriteLine(sb);

            escritor.Close();




            return true;
        }
    }

}
