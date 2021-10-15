using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace PetShopForms
{
    public partial class FrmEmpleados : Form
    {
        Empleado empleado;
        FrmABM abm;
        int controlador = 0;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, System.EventArgs e)
        {
            
            foreach (Usuario item in Local.Nomina)
            {
                if (typeof(Empleado) == item.GetType())
                {
                    lstb_Nomina.Items.Add(item.Datos());
                }
            }

            btn_BajaEmpleado.ForeColor = Color.Red;

            ActualizarNominaLstbx();
        }


        private void btn_BajaEmpleado_Click(object sender, System.EventArgs e)
        {
            int aux = 0;
            int indice = -1;
            lblErrores.Visible = false;

            if (txtb_IdBaja.Text != null && int.TryParse(txtb_IdBaja.Text, out aux))
            {

                foreach (Usuario item in Local.Nomina)
                {
                    if (typeof(Empleado) == item.GetType())
                    {
                        empleado = (Empleado)item;

                        if (empleado.Id == aux)
                        {
                            if (MessageBox.Show($"Desea elimiar a {item.Nombre} {item.Apellido}?",
                                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                indice = Local.Nomina.IndexOf(item);
                            }
                        }

                    }
                }

                if (indice == -1)
                {
                    lblErrores.Visible = true;
                    lblErrores.Text = "ERROR: No existe un empleado con esa ID";
                }
                else
                {
                    Local.Nomina.RemoveAt(indice);
                    txtb_IdBaja.Text = string.Empty;
                }
                ActualizarNominaLstbx();
            }
            else
            {
                lblErrores.Visible = true;
                lblErrores.Text = "ERROR: Ingrese un numero valido de ID";
            }
        }

        public void ActualizarNominaLstbx()
        {
            if (lstb_Nomina.Items.Count != 0)
            {
                lstb_Nomina.Items.Clear();

                foreach (Usuario item in Local.Nomina)
                {
                    if (typeof(Empleado) == item.GetType())
                    {
                        lstb_Nomina.Items.Add(item.Datos());

                    }
                }

            }

        }

        private void FrmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = true;
            }else
            {
                
            }
        }

        private void btn_AltaEmpleado_Click(object sender, System.EventArgs e)
        {
            controlador = 1;
            abm = new FrmABM(controlador);
            abm.BackColor = Color.Salmon;
            if (abm.ShowDialog() == DialogResult.OK )
            {
                Local.Nomina.Add(abm.Empleado);
                lstb_Nomina.Items.Add(abm.Empleado.Datos());
            }
            
        }

        private void btn_ModificarEmpleado_Click(object sender, System.EventArgs e)
        {
            int indice = 0;

            if (lstb_Nomina.SelectedItem != null)
            {
                controlador = 2;
                abm = new FrmABM(controlador);
                abm.BackColor = Color.DarkSalmon;

                if (abm.ShowDialog() == DialogResult.OK)
                {
                    foreach (Usuario item in Local.Nomina)
                    {
                        if (item.Datos() == lstb_Nomina.SelectedItem.ToString())
                        {
                            empleado = (Empleado) item;
                            indice = Local.Nomina.IndexOf(item);
                        }
                    }

                    abm.Empleado.Id = empleado.Id;
                    Local.Nomina.RemoveAt(indice);
                    Local.Nomina.Insert(indice, abm.Empleado);
                }        
                ActualizarNominaLstbx();
            }
            else
            {
                lblErrores.Visible = true;
                lblErrores.Text = "Error al dar el alta del empleado";
            }

        }    
    }
}
