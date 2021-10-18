using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
namespace PetShopForms
{
    public partial class FrmLogin : Form
    {
        Usuario aux;
        bool colorCambiado = false;
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblErrorUsuario.Visible = false;
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
            lblErrorUsuario.Visible = false;
            try
            {
                aux = Local.LoguearUsuario(txtb_Usuario.Text, txtb_Contraseña.Text);

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
                }

                this.Show();

            }
            catch (UsuarioInvalidoException UsuarioException)
            {
                lblErrorUsuario.Visible = true;
                lblErrorUsuario.Text = UsuarioException.Message;
            }

        }

        private void btn_CompletarComoEmpleado_Click(object sender, EventArgs e)
        {
            lblErrorUsuario.Visible = false;
            aux = Local.LoguearUsuario("Obiwan", "Kenobi");

            txtb_Usuario.Text = "Obiwan";
            txtb_Contraseña.Text = "Kenobi";
        }
        private void btn_CompletarComoAdmin_Click(object sender, EventArgs e)
        {
            lblErrorUsuario.Visible = false;
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

        private void btn_DarkMode_Click(object sender, EventArgs e)
        {
            if (colorCambiado == false)
            {
                
                this.ForeColor = Color.DarkRed;
                this.BackColor = Color.Black;
                lstView_Nomina.BackColor = Color.Black;
                lstView_Nomina.ForeColor = Color.DarkRed;
                btnLogInAdministrativo.BackColor = Color.Black;
                btn_DarkMode.BackColor = Color.Black;
                btn_CompletarComoAdmin.BackColor = Color.Black;
                btn_CompletarComoEmpleado.BackColor = Color.Black;
                txtb_Contraseña.BackColor = Color.Black;
                txtb_Contraseña.ForeColor = Color.DarkRed;
                txtb_Usuario.BackColor = Color.Black;
                txtb_Usuario.ForeColor = Color.DarkRed;
                lblErrorUsuario.ForeColor = Color.White;
                colorCambiado = true;

            }else
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.Moccasin;
                btnLogInAdministrativo.BackColor = Color.Transparent;
                btn_CompletarComoAdmin.BackColor = Color.Transparent;
                btn_CompletarComoEmpleado.BackColor = Color.Transparent;
                btn_DarkMode.BackColor = Color.Transparent;
                lstView_Nomina.BackColor = Color.White;
                lstView_Nomina.ForeColor = Color.Black;
                txtb_Contraseña.BackColor = Color.White;
                txtb_Contraseña.ForeColor = Color.Black;
                txtb_Usuario.BackColor = Color.White;
                txtb_Usuario.ForeColor = Color.Black;
                lblErrorUsuario.ForeColor = Color.Black;
                colorCambiado = false;
            }
        }
    }
}
