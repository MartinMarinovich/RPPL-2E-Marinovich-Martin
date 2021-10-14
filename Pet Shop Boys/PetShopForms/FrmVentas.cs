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
    public partial class FrmVentas : Form
    {
        Usuario usuarioLogueado = null;
        Cliente cliente = null;
        Compra compra = null;
        Envio envio = null;
        Producto auxProducto;

        List<Producto> listaAux = new List<Producto>();

        bool pedidoTerminado = false;
        bool clienteseleccionado = false;
        float auxMonto = 0;
        public FrmVentas(Usuario aux)
        {
            InitializeComponent();
            usuarioLogueado = aux;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            if (typeof(Empleado) == usuarioLogueado.GetType())
            {
                btn_HistorialDeVentas.Visible = false;
                grpbAltas.Visible = false;
            }

            lbl_Errores.Visible = false;
            btn_AgregarProducto.Enabled = false;
            btn_FinalizarVenta.Enabled = false;
            txt_CantidadDeProducto.Enabled = false;

            foreach (Producto item in Local.Stock)
            {
                lstb_Productos.Items.Add(item.DatosProducto());

            }
            foreach (Cliente item in Local.Clientela)
            {
                lstb_Clientes.Items.Add(item.DatosCliente());

            }


        }

        private void btn_AltaCliente_Click(object sender, EventArgs e)
        {
            if (Local.ValidarString(txtb_Nombre.Text) && Local.ValidarString(txtb_Apellido.Text) && Local.ValidarStringNumerico(txtb_Dni.Text))
            {
                cliente = new Cliente(txtb_Nombre.Text, txtb_Apellido.Text, double.Parse(txtb_Dni.Text));
                Local.Clientela.Push(cliente);
                ActualizarCampos();
            }
            else
            {
                lbl_Errores.Visible = true;
            }
            LimpiarCampos();
        }

        private void btn_RealizarVenta_Click(object sender, EventArgs e)
        {
            int auxCant = 0;
            int indice = 0;
            int stockproducto = 0;
            double dineroCliente = 0;

            if (pedidoTerminado == true)
            {
                listaAux = new List<Producto>();
                pedidoTerminado = false;
            }

            if (Local.ValidarStringNumerico(txt_CantidadDeProducto.Text) && lstb_Productos.SelectedItem != null)
            {
                
                auxCant = int.Parse(txt_CantidadDeProducto.Text);

                if (clienteseleccionado == true)
                {
                    dineroCliente = cliente.Dinero;
                    for (int i = 0; i <auxCant; i++)
                    {
                        foreach (Producto item in Local.Stock)
                        {
                            if (item.DatosProducto() == lstb_Productos.SelectedItem.ToString())
                            {
                                auxProducto = item;
                                stockproducto = auxProducto.Stock;
                                stockproducto = stockproducto - auxCant;

                                if (stockproducto >= 0 && dineroCliente >= 0)
                                {
                                    indice = Local.Stock.IndexOf(item);
                                    listaAux.Add(item);
                                    auxMonto = auxMonto + item.Precio;
                                }else
                                {
                                    lbl_Errores.Text = "No hay mas stock del producto";
                                   
                                }
                            }
                        }
                    }
                    auxProducto.Stock = stockproducto;
                    Local.Stock.RemoveAt(indice);
                    Local.Stock.Insert(indice, auxProducto);
                    ActualizarCampos();
                }
                else
                {
                    lbl_Errores.Text = "Error, seleccione un cliente para realizar la venta";
                }

            }
            else
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Debe seleccionar un producto, la cantidad del mismo y un cliente para realizar la venta";
            }

            LimpiarCampos();
        }
        private void btn_FinalizarVenta_Click(object sender, EventArgs e)
        {
            pedidoTerminado = true;
            btn_IniciarPedido.Enabled = true;
            envio = Local.AsignarEnvio(cliente, listaAux);
            compra = new Compra(cliente, auxMonto, listaAux, envio);
            Local.Ventas.Add(compra);
            lstb_Clientes.Enabled = true;
            lstb_HistorialVentas.Items.Add("");
            lstb_HistorialVentas.Items.Add("PEDIDO FINALIZADO");
            lstb_HistorialVentas.Items.Add("");
            lstb_HistorialVentas.Items.Add($"Total a pagar productos: ${auxMonto}");
            lstb_HistorialVentas.Items.Add($"Costo de envio: ${envio.Precio}");
            lstb_HistorialVentas.Items.Add("");
            lstb_HistorialVentas.Items.Add($"MONTO TOTAL DEL PEDIDO: ${envio.Precio + auxMonto}");
            LimpiarCampos();
        }


        protected void ActualizarCampos()
        {
            if (lstb_Clientes.Items.Count != 0)
            {
                lstb_Clientes.Items.Clear();

                foreach (Cliente item in Local.Clientela)
                {
                    lstb_Clientes.Items.Add(item.DatosCliente());

                }
            }

            if (lstb_Productos.Items.Count != 0)
            {
                lstb_Productos.Items.Clear();

                foreach (Producto item in Local.Stock)
                {
                    lstb_Productos.Items.Add(item.DatosProducto());

                }
            }

            if (listaAux != null)
            {             
                lstb_HistorialVentas.Items.Clear();
                lstb_HistorialVentas.Items.Add("*** PEDIDO EN CURSO ***");
                lstb_HistorialVentas.Items.Add("");
                lstb_HistorialVentas.Items.Add("Nombre        Apellido        DNI          Dinero");
                lstb_HistorialVentas.Items.Add("");
                lstb_HistorialVentas.Items.Add(cliente.DatosCliente());
                lstb_HistorialVentas.Items.Add("");
                lstb_HistorialVentas.Items.Add("Producto        Descripcion        Precio          Dinero");
                lstb_HistorialVentas.Items.Add("");

                foreach (Producto item in listaAux)
                {
                   
                    lstb_HistorialVentas.Items.Add(item.DatosParaVenta());
                }
            }
        }

        private void FrmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LimpiarCampos()
        {
            txtb_Apellido.Text = string.Empty;
            txtb_Dni.Text = string.Empty;
            txtb_Nombre.Text = string.Empty;
            txt_CantidadDeProducto.Text = string.Empty;

        }

        private void btn_IniciarPedido_Click(object sender, EventArgs e)
        {
            if (pedidoTerminado == false)
            {
                btn_IniciarPedido.Enabled = false;
                btn_FinalizarVenta.Enabled = true;
            }

            if (clienteseleccionado == false)
            {
                foreach (Cliente item in Local.Clientela)
                {
                    if (item.DatosCliente() == lstb_Clientes.SelectedItem.ToString())
                    {
                        cliente = item;
                        clienteseleccionado = true;
                        btn_AgregarProducto.Enabled = true;
                        txt_CantidadDeProducto.Enabled = true;
                        lstb_Clientes.Enabled = false;
                    }

                }

                if (cliente != null)
                {
                    lstb_HistorialVentas.Items.Clear();
                    lstb_HistorialVentas.Items.Add("*** PEDIDO EN CURSO ***");
                    lstb_HistorialVentas.Items.Add("");
                    lstb_HistorialVentas.Items.Add("Nombre        Apellido        DNI          Dinero");
                    lstb_HistorialVentas.Items.Add("");
                    lstb_HistorialVentas.Items.Add(cliente.DatosCliente());
                    lstb_HistorialVentas.Items.Add("");
                    lstb_HistorialVentas.Items.Add("Producto        Descripcion        Precio          Dinero");
                    lstb_HistorialVentas.Items.Add("");
                }
            }
        }

        private void btn_HistorialDeVentas_Click(object sender, EventArgs e)
        {
            FrmHistorialVentas formventas = new FrmHistorialVentas();
            formventas.Show();
        }
    }
}
