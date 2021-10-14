
namespace PetShopForms
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuPrincipal.ForeColor = System.Drawing.Color.Coral;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(164, 9);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(386, 72);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "Menu Principal";
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Empleados.ForeColor = System.Drawing.Color.Black;
            this.btn_Empleados.Location = new System.Drawing.Point(3, 467);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(209, 66);
            this.btn_Empleados.TabIndex = 2;
            this.btn_Empleados.Text = "Panel de empleados";
            this.btn_Empleados.UseVisualStyleBackColor = false;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click_1);
            // 
            // btn_Stock
            // 
            this.btn_Stock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Stock.Location = new System.Drawing.Point(270, 467);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(251, 66);
            this.btn_Stock.TabIndex = 3;
            this.btn_Stock.Text = "Stock";
            this.btn_Stock.UseVisualStyleBackColor = false;
            this.btn_Stock.Click += new System.EventHandler(this.btn_Stock_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ventas.Location = new System.Drawing.Point(585, 467);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(239, 66);
            this.btn_Ventas.TabIndex = 4;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = false;
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEmpleados.Location = new System.Drawing.Point(3, 404);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(234, 46);
            this.lblEmpleados.TabIndex = 5;
            this.lblEmpleados.Text = "Adminstracion de empleados";
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStock.Location = new System.Drawing.Point(287, 404);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(234, 46);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Control de Stock";
            // 
            // lblVentas
            // 
            this.lblVentas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblVentas.Location = new System.Drawing.Point(585, 404);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(224, 46);
            this.lblVentas.TabIndex = 7;
            this.lblVentas.Text = "Gestion de Ventas";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(825, 535);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.btn_Ventas);
            this.Controls.Add(this.btn_Stock);
            this.Controls.Add(this.btn_Empleados);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblVentas;
    }
}