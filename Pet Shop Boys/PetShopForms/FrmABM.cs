using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShopForms
{
    public partial class FrmABM : Form
    {
        Empleado empleado;
        int controlador = 0;


        public Empleado Empleado
        {
            get
            {
                return empleado;
            }
        }
        public FrmABM(int aux)
        {
            InitializeComponent();
            controlador = aux;
        }

        public void btn_AltaEmpleado_Click(object sender, EventArgs e)
        {
            double auxDni;
            lblErroresAbm.Visible = false;
            try
            {
                if (Local.ValidarString(txtb_NombreAlta.Text) && Local.ValidarString(txtb_ApellidoALta.Text)
                 && Local.ValidarString(txb_Usuario.Text) && Local.ValidarString(txtb_Contraseña.Text)
                 && double.TryParse(txtb_DniAlta.Text, out auxDni)
                 && Local.ValidarStringNumerico(txtb_SueldoAlta.Text))
                {
                    Local.ValidarDNI(auxDni);
 
                     empleado = new(txtb_NombreAlta.Text, txtb_ApellidoALta.Text, double.Parse(txtb_DniAlta.Text), float.Parse(txtb_SueldoAlta.Text)
                        , txb_Usuario.Text, txtb_Contraseña.Text);

                    this.DialogResult = DialogResult.OK;
                    SystemSounds.Hand.Play();
                    this.Close();
                }else
                {
                    lblErroresAbm.Visible = true;
                    lblErroresAbm.Text = "Error, complete los campos con valores validos";
                    this.Limpiar();
                }
            }
            catch (DniException DniInvalido)
            {
                lblErroresAbm.Visible = true;
                this.Limpiar();
                lblErroresAbm.Text = DniInvalido.Message;
            }
        }

        private void FrmABM_Load(object sender, EventArgs e)
        {
            lblErroresAbm.Visible = false;
            if (controlador == 2)
            {
                LblUsuario.Visible = false;
                lblContraseña.Visible = false;
                btn_AltaEmpleado.Visible = false;
                txtb_Contraseña.Visible = false;
                txb_Usuario.Visible = false;
            }
            else
            {
                btn_ModificarEmpleado.Visible = false;
            }
        }

        private void btn_ModificarEmpleado_Click(object sender, EventArgs e)
        {

            if (Local.ValidarString(txtb_NombreAlta.Text) && Local.ValidarString(txtb_ApellidoALta.Text)
                && Local.ValidarStringNumerico(txtb_SueldoAlta.Text))
            {
                empleado = new(txtb_NombreAlta.Text, txtb_ApellidoALta.Text, double.Parse(txtb_DniAlta.Text), float.Parse(txtb_SueldoAlta.Text)
                     , txb_Usuario.Text, txtb_Contraseña.Text);
                this.DialogResult = DialogResult.OK;
                SystemSounds.Hand.Play();
                this.Close();
            }
            else
            {

                lblErroresAbm.Text = "Error, complete los campos con valores validos";
                this.Limpiar();
            }

        }


        protected void Limpiar()
        {
            txtb_NombreAlta.Text = string.Empty;
            txtb_ApellidoALta.Text = string.Empty;
            txb_Usuario.Text = string.Empty;
            txtb_SueldoAlta.Text = string.Empty;
            txtb_DniAlta.Text = string.Empty;
            txtb_Contraseña.Text = string.Empty;
        }
    }

}
