using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace PetShopForms
{
    public partial class FrmHistorialVentas : Form
    {
        public FrmHistorialVentas()
        {
            InitializeComponent();
        }

        private void FrmHistorialVentas_Load(object sender, EventArgs e)
        {
            CargarListaDeVentas();
        }

        /// <summary>
        /// Metodo privado del form que carga la lista historica de ventas a la fecha
        /// </summary>
        private void CargarListaDeVentas()
        {
            double acumuladoProductos = 0;
            double acumulador = 0;
            double gastoTotal = 0;
            StringBuilder sb = new StringBuilder();

            string datosComprador = "";
            string envio = "";
            string productos = "";
            string headerCompra = string.Format("{0,-8}{1,6}  {2,8}{3,8}", "Tipo", "Descripcion", "Precio", "Cantidad");
            string headerCliente = string.Format("{0,-7}{1,3}{2,9}", "Nombre", "Apellido", "NRº DNI");



            foreach (Compra item in Local.Ventas)
            {
                lstb_HistorialVentas.Items.Add(headerCliente);
                datosComprador = string.Format("{0,-10}{1,6}{2,9}", item.Comprador.Nombre, item.Comprador.Apellido, item.Comprador.DNI);
                lstb_HistorialVentas.Items.Add("");
                lstb_HistorialVentas.Items.Add(datosComprador);
                lstb_HistorialVentas.Items.Add("");
                lstb_HistorialVentas.Items.Add(headerCompra);
                lstb_HistorialVentas.Items.Add("");
                foreach (Producto prod in item.Carrito)
                {

                    productos = string.Format("{0,-8}{1,8}  {2,8} {3,10}", prod.Tipo, prod.Descripcion, prod.Precio, prod.Stock);
                    lstb_HistorialVentas.Items.Add(productos);

                }
                lstb_HistorialVentas.Items.Add("");
                acumuladoProductos = acumuladoProductos + item.EnvioCompra.Precio + item.Monto;
                lstb_HistorialVentas.Items.Add("GASTO PRODUCTOS: $" + acumuladoProductos.ToString());
                lstb_HistorialVentas.Items.Add("");
                envio = string.Format("ENVIO: {0,-7} ${1,3}", item.EnvioCompra.Transporte, item.EnvioCompra.Precio);
                lstb_HistorialVentas.Items.Add(envio);
                lstb_HistorialVentas.Items.Add("");

                acumuladoProductos = 0;
                gastoTotal = item.EnvioCompra.Precio + item.Monto;
                acumulador = acumulador + gastoTotal;
            }

            lbl_MontoHistorico.Text = "Dinero Generado en Ventas: " + acumulador;
        }
    }
}
