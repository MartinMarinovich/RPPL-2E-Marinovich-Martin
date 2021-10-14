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
            foreach (Compra item in Local.Ventas)
            {
                
               lstb_HistorialVentas.Items.Add(item.Datos());
                lstb_HistorialVentas.Items.Add(item.MostrarCarrito());
            }
            
        }
    }
}
