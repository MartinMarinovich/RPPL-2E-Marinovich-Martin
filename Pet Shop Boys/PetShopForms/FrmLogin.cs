using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
namespace PetShopForms
{
    public partial class FrmLogin : Form
    { 
        Usuario aux;
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            ListViewGroup Admins = new ListViewGroup("Administradores", HorizontalAlignment.Left);
            ListViewGroup Emps = new ListViewGroup("Empleados", HorizontalAlignment.Left);

            foreach (Usuario item in Local.Nomina)
            {
                if (typeof(Empleado) == item.GetType())
                {
                    lstView_Nomina.Items.Add(new ListViewItem(item.DatosLogin(), Emps));
                }
                else
                {
                    lstView_Nomina.Items.Add(new ListViewItem(item.DatosLogin(), Admins));
                }

            }

            lstView_Nomina.Groups.Add(Admins);
            lstView_Nomina.Groups.Add(Emps);

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            if (aux != null)
            {
                if (typeof(Empleado) == aux.GetType())
                {
                    FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(aux);
                    menuPrincipal.BackColor = Color.Salmon;
                    this.Hide();
                    menuPrincipal.ShowDialog();
                }
                else
                {
                    FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(aux);
                    this.Hide();
                    menuPrincipal.ShowDialog();
                }

                this.Show();
            }
            else
            {
                MessageBox.Show("Error, ingreso un usuario o contraseña incorrecto");
            }
        }

        private void btn_CompletarComoEmpleado_Click(object sender, EventArgs e)
        {
            aux = Local.LoguearUsuario("Obiwan", "Kenobi");

            txtb_Usuario.Text = "Obiwan";
            txtb_Contraseña.Text = "Kenobi";

        }

        private void btn_CompletarComoAdmin_Click(object sender, EventArgs e)
        {
            aux = Local.LoguearUsuario("Sudo", "Suuu");

            txtb_Usuario.Text = "Sudo";
            txtb_Contraseña.Text = "Suuu";
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
