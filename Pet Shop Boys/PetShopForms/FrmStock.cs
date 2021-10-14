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
using static Entidades.Enumerados;

namespace PetShopForms
{
    public partial class FrmStock : Form
    {
        Producto producto;

        public FrmStock()
        {
            InitializeComponent();


        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            lbl_ErrorAlta.Visible = false;
            foreach (Producto item in Local.Stock)
            {
                lstb_Productos.Items.Add(item.DatosProducto());
            }

            cmb_Tipos.DataSource = Enum.GetValues(typeof(Eproducto));
        }


        /// <summary>
        /// Meotod protegido del formulario que actualiza la lista de productos haciendo el clear y volviendo a asignar los productos
        /// </summary>
        protected void ActualizarProductos()
        {
            if (lstb_Productos.Items.Count != 0)
            {
                lstb_Productos.Items.Clear();

                foreach (Producto item in Local.Stock)
                {

                    lstb_Productos.Items.Add(item.DatosProducto());
                }
            }
            else
            {
                lstb_Productos.Items.Add("No hay productos cargados");
            }
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {

            if (Local.ValidarStringNumerico(txtb_Precio.Text) && Local.ValidarStringNumerico(txtb_Cantidad.Text)
                && cmb_Tipos.SelectedItem != null
                 && Local.ValidarStringNumerico(txtb_Codigo.Text) && Local.ValidarString(txtb_Descripcion.Text))
            {
                Eproducto aux;
                aux = (Eproducto)cmb_Tipos.SelectedItem;
                producto = new Producto(double.Parse(txtb_Codigo.Text), float.Parse(txtb_Precio.Text), int.Parse(txtb_Cantidad.Text), aux, txtb_Descripcion.Text);
                Local.Stock.Add(producto);
                ActualizarProductos();
                LimpiarCampos();
            }
            else
            {
                LimpiarCampos();
                lbl_ErrorAlta.Visible = true;
                ActualizarProductos();
            }
        }

        private void btn_AumentarStock_Click(object sender, EventArgs e)
        {
            int indice = 0;
            int auxiiar = 0;


            if (lstb_Productos.SelectedItem != null)
            {

                foreach (Producto item in Local.Stock)
                {

                    if (lstb_Productos.SelectedItem.ToString() == item.DatosProducto())
                    {
                        indice = Local.Stock.IndexOf(item);
                        auxiiar = int.Parse(txtb_CantAumentar.Text);
                        auxiiar = auxiiar + item.Stock;
                        item.Stock = auxiiar;
                        producto = item;
                    }

                }
                Local.Stock.RemoveAt(indice);
                Local.Stock.Insert(indice, producto);
                LimpiarCampos();
                ActualizarProductos();
            }
            else
            {
                lbl_ErrorAlta.Text = "Error, seleccione un item y coloque una cantidad mayor a 0";
                lbl_ErrorAlta.Visible = true;
                LimpiarCampos();
                ActualizarProductos();
            }
        }

        private void btn_ReducirStock_Click(object sender, EventArgs e)
        {
            int indice = 0;
            int auxiiar = 0;


            if (lstb_Productos.SelectedItem != null && int.Parse(txtb_CantidadReducir.Text) > 0)
            {

                foreach (Producto item in Local.Stock)
                {

                    if (lstb_Productos.SelectedItem.ToString() == item.DatosProducto())
                    {
                        indice = Local.Stock.IndexOf(item);
                        auxiiar = int.Parse(txtb_CantidadReducir.Text);
                        auxiiar = item.Stock - auxiiar;
                        item.Stock = auxiiar;
                        producto = item;
                    }
                }

                if (auxiiar < 0)
                {
                    lbl_ErrorAlta.Text = "Error, el producto no puede tener una cantidad menor a 0";
                    lbl_ErrorAlta.Visible = true;
                    LimpiarCampos();
                }
                else
                {
                    Local.Stock.RemoveAt(indice);
                    Local.Stock.Insert(indice, producto);
                    LimpiarCampos();
                    ActualizarProductos();
                }
            }
            else
            {
                lbl_ErrorAlta.Text = "Error, seleccione un item para reducir y coloque un valor correcto";
                lbl_ErrorAlta.Visible = true;
                LimpiarCampos();
                ActualizarProductos();
            }

        }

        private void FrmStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LimpiarCampos()
        {
            txtb_CantAumentar.Text = string.Empty;
            txtb_CantidadReducir.Text = string.Empty;
            txtb_Codigo.Text = string.Empty;
            txtb_Descripcion.Text = string.Empty;
            txtb_Precio.Text = string.Empty;
            txtb_Cantidad.Text = string.Empty;

        }
    }
}
