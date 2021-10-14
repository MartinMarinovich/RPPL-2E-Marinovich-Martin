
namespace PetShopForms
{
    partial class FrmStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.lstb_Productos = new System.Windows.Forms.ListBox();
            this.btn_ReducirStock = new System.Windows.Forms.Button();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.txtb_Descripcion = new System.Windows.Forms.TextBox();
            this.txtb_Codigo = new System.Windows.Forms.TextBox();
            this.txtb_Cantidad = new System.Windows.Forms.TextBox();
            this.txtb_Precio = new System.Windows.Forms.TextBox();
            this.txtb_CantAumentar = new System.Windows.Forms.TextBox();
            this.txtb_CantidadReducir = new System.Windows.Forms.TextBox();
            this.btn_AumentarStock = new System.Windows.Forms.Button();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblTipos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescipcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmb_Tipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ErrorAlta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstb_Productos
            // 
            this.lstb_Productos.FormattingEnabled = true;
            this.lstb_Productos.ItemHeight = 15;
            this.lstb_Productos.Location = new System.Drawing.Point(-4, 275);
            this.lstb_Productos.Name = "lstb_Productos";
            this.lstb_Productos.Size = new System.Drawing.Size(489, 214);
            this.lstb_Productos.TabIndex = 0;
            // 
            // btn_ReducirStock
            // 
            this.btn_ReducirStock.Location = new System.Drawing.Point(29, 136);
            this.btn_ReducirStock.Name = "btn_ReducirStock";
            this.btn_ReducirStock.Size = new System.Drawing.Size(147, 39);
            this.btn_ReducirStock.TabIndex = 1;
            this.btn_ReducirStock.Text = "Reducir Cantidad";
            this.btn_ReducirStock.UseVisualStyleBackColor = true;
            this.btn_ReducirStock.Click += new System.EventHandler(this.btn_ReducirStock_Click);
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(34, 276);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(151, 39);
            this.btn_AgregarProducto.TabIndex = 2;
            this.btn_AgregarProducto.Text = "Agregar Producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // txtb_Descripcion
            // 
            this.txtb_Descripcion.Location = new System.Drawing.Point(253, 138);
            this.txtb_Descripcion.Name = "txtb_Descripcion";
            this.txtb_Descripcion.PlaceholderText = "Descripcion producto";
            this.txtb_Descripcion.Size = new System.Drawing.Size(152, 23);
            this.txtb_Descripcion.TabIndex = 4;
            // 
            // txtb_Codigo
            // 
            this.txtb_Codigo.Location = new System.Drawing.Point(254, 71);
            this.txtb_Codigo.Name = "txtb_Codigo";
            this.txtb_Codigo.PlaceholderText = "Codigo producto";
            this.txtb_Codigo.Size = new System.Drawing.Size(151, 23);
            this.txtb_Codigo.TabIndex = 7;
            // 
            // txtb_Cantidad
            // 
            this.txtb_Cantidad.Location = new System.Drawing.Point(253, 218);
            this.txtb_Cantidad.Name = "txtb_Cantidad";
            this.txtb_Cantidad.PlaceholderText = "Ingrese cantidad";
            this.txtb_Cantidad.Size = new System.Drawing.Size(152, 23);
            this.txtb_Cantidad.TabIndex = 8;
            // 
            // txtb_Precio
            // 
            this.txtb_Precio.Location = new System.Drawing.Point(254, 291);
            this.txtb_Precio.Name = "txtb_Precio";
            this.txtb_Precio.PlaceholderText = "Ingrese precio";
            this.txtb_Precio.Size = new System.Drawing.Size(152, 23);
            this.txtb_Precio.TabIndex = 9;
            // 
            // txtb_CantAumentar
            // 
            this.txtb_CantAumentar.Location = new System.Drawing.Point(212, 75);
            this.txtb_CantAumentar.Name = "txtb_CantAumentar";
            this.txtb_CantAumentar.PlaceholderText = "Cantidad a aumentar";
            this.txtb_CantAumentar.Size = new System.Drawing.Size(147, 23);
            this.txtb_CantAumentar.TabIndex = 12;
            // 
            // txtb_CantidadReducir
            // 
            this.txtb_CantidadReducir.Location = new System.Drawing.Point(29, 75);
            this.txtb_CantidadReducir.Name = "txtb_CantidadReducir";
            this.txtb_CantidadReducir.PlaceholderText = "Cantidad a reducir";
            this.txtb_CantidadReducir.Size = new System.Drawing.Size(147, 23);
            this.txtb_CantidadReducir.TabIndex = 11;
            // 
            // btn_AumentarStock
            // 
            this.btn_AumentarStock.Location = new System.Drawing.Point(212, 136);
            this.btn_AumentarStock.Name = "btn_AumentarStock";
            this.btn_AumentarStock.Size = new System.Drawing.Size(147, 39);
            this.btn_AumentarStock.TabIndex = 10;
            this.btn_AumentarStock.Text = "Agregar Cantidad";
            this.btn_AumentarStock.UseVisualStyleBackColor = true;
            this.btn_AumentarStock.Click += new System.EventHandler(this.btn_AumentarStock_Click);
            // 
            // lblInventario
            // 
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInventario.Location = new System.Drawing.Point(-4, 9);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(264, 53);
            this.lblInventario.TabIndex = 13;
            this.lblInventario.Text = "Control de Stock";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.Location = new System.Drawing.Point(-4, 206);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(188, 23);
            this.lblProductos.TabIndex = 14;
            this.lblProductos.Text = "Productos Disponibles";
            // 
            // lblTipos
            // 
            this.lblTipos.Location = new System.Drawing.Point(34, 45);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(100, 23);
            this.lblTipos.TabIndex = 15;
            this.lblTipos.Text = "Tipo de Producto";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(254, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(254, 192);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 23);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescipcion
            // 
            this.lblDescipcion.Location = new System.Drawing.Point(254, 112);
            this.lblDescipcion.Name = "lblDescipcion";
            this.lblDescipcion.Size = new System.Drawing.Size(100, 23);
            this.lblDescipcion.TabIndex = 18;
            this.lblDescipcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(253, 266);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 23);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio";
            // 
            // cmb_Tipos
            // 
            this.cmb_Tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipos.FormattingEnabled = true;
            this.cmb_Tipos.Location = new System.Drawing.Point(34, 88);
            this.cmb_Tipos.Name = "cmb_Tipos";
            this.cmb_Tipos.Size = new System.Drawing.Size(151, 23);
            this.cmb_Tipos.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo del Producto";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(212, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad a Modificar";
            // 
            // lbl_ErrorAlta
            // 
            this.lbl_ErrorAlta.BackColor = System.Drawing.Color.Red;
            this.lbl_ErrorAlta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ErrorAlta.Location = new System.Drawing.Point(34, 162);
            this.lbl_ErrorAlta.Name = "lbl_ErrorAlta";
            this.lbl_ErrorAlta.Size = new System.Drawing.Size(135, 53);
            this.lbl_ErrorAlta.TabIndex = 23;
            this.lbl_ErrorAlta.Text = "Error, ingrese correctamente los campos";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-4, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(89, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipo de Producto";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(179, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(312, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(418, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Precio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AumentarStock);
            this.groupBox1.Controls.Add(this.btn_ReducirStock);
            this.groupBox1.Controls.Add(this.txtb_CantidadReducir);
            this.groupBox1.Controls.Add(this.txtb_CantAumentar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(553, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 191);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODIFICACION STOCK";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtb_Cantidad);
            this.groupBox2.Controls.Add(this.btn_AgregarProducto);
            this.groupBox2.Controls.Add(this.txtb_Descripcion);
            this.groupBox2.Controls.Add(this.txtb_Codigo);
            this.groupBox2.Controls.Add(this.txtb_Precio);
            this.groupBox2.Controls.Add(this.lblTipos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_ErrorAlta);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.cmb_Tipos);
            this.groupBox2.Controls.Add(this.lblDescipcion);
            this.groupBox2.Controls.Add(this.lblPrecio);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(553, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 336);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALTA PRODUCTO";
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lstb_Productos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStock_FormClosing);
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_Productos;
        private System.Windows.Forms.Button btn_ReducirStock;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.TextBox txtb_Descripcion;
        private System.Windows.Forms.TextBox txtb_Codigo;
        private System.Windows.Forms.TextBox txtb_Cantidad;
        private System.Windows.Forms.TextBox txtb_Precio;
        private System.Windows.Forms.TextBox txtb_CantAumentar;
        private System.Windows.Forms.TextBox txtb_CantidadReducir;
        private System.Windows.Forms.Button btn_AumentarStock;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescipcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmb_Tipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ErrorAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}