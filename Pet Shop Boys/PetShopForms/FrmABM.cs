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
            
            if (Local.ValidarString(txtb_NombreAlta.Text) && Local.ValidarString(txtb_ApellidoALta.Text)
            && Local.ValidarString(txb_Usuario.Text) && Local.ValidarString(txtb_Contraseña.Text)
            && Local.ValidarDNI(double.Parse(txtb_DniAlta.Text)) && Local.ValidarStringNumerico(txtb_SueldoAlta.Text))
            {
                empleado = new(txtb_NombreAlta.Text, txtb_ApellidoALta.Text, double.Parse(txtb_DniAlta.Text), float.Parse(txtb_SueldoAlta.Text)
                    , txb_Usuario.Text, txtb_Contraseña.Text);

                this.DialogResult = DialogResult.OK;        
                this.Close();

            }
            else
            {
                MessageBox.Show("Error, debe completar los campos para cargar un empleado");
            }
        }

        private void FrmABM_Load(object sender, EventArgs e)
        {
          
            if (controlador == 2)
            {
                LblUsuario.Visible = false;
                lblContraseña.Visible = false;
                btn_AltaEmpleado.Visible = false;
                txtb_Contraseña.Visible = false;
                txb_Usuario.Visible = false;
            }else
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
                this.Close();
            }
            else
            {

                MessageBox.Show("Error, debe completar los campos para modificar un empleado");
            }
            
        }
    }

}
