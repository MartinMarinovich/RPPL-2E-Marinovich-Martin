
namespace PetShopForms
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.btn_AltaEmpleado = new System.Windows.Forms.Button();
            this.btn_ModificarEmpleado = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btn_BajaEmpleado = new System.Windows.Forms.Button();
            this.txtb_IdBaja = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstb_Nomina = new System.Windows.Forms.ListBox();
            this.lblErrores = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AltaEmpleado
            // 
            this.btn_AltaEmpleado.Location = new System.Drawing.Point(630, 451);
            this.btn_AltaEmpleado.Name = "btn_AltaEmpleado";
            this.btn_AltaEmpleado.Size = new System.Drawing.Size(101, 40);
            this.btn_AltaEmpleado.TabIndex = 48;
            this.btn_AltaEmpleado.Text = "Alta Empleado";
            this.btn_AltaEmpleado.UseVisualStyleBackColor = true;
            this.btn_AltaEmpleado.Click += new System.EventHandler(this.btn_AltaEmpleado_Click);
            // 
            // btn_ModificarEmpleado
            // 
            this.btn_ModificarEmpleado.Location = new System.Drawing.Point(409, 451);
            this.btn_ModificarEmpleado.Name = "btn_ModificarEmpleado";
            this.btn_ModificarEmpleado.Size = new System.Drawing.Size(101, 40);
            this.btn_ModificarEmpleado.TabIndex = 50;
            this.btn_ModificarEmpleado.Text = "Modificar Empleado";
            this.btn_ModificarEmpleado.UseVisualStyleBackColor = true;
            this.btn_ModificarEmpleado.Click += new System.EventHandler(this.btn_ModificarEmpleado_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleados.Location = new System.Drawing.Point(3, 0);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(378, 47);
            this.lblEmpleados.TabIndex = 0;
            this.lblEmpleados.Text = "Administracion de Empleados";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(43, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(185, 29);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Ingrese el ID a dar de baja";
            // 
            // btn_BajaEmpleado
            // 
            this.btn_BajaEmpleado.Location = new System.Drawing.Point(43, 144);
            this.btn_BajaEmpleado.Name = "btn_BajaEmpleado";
            this.btn_BajaEmpleado.Size = new System.Drawing.Size(263, 34);
            this.btn_BajaEmpleado.TabIndex = 2;
            this.btn_BajaEmpleado.Text = "Baja Empleado";
            this.btn_BajaEmpleado.UseVisualStyleBackColor = true;
            this.btn_BajaEmpleado.Click += new System.EventHandler(this.btn_BajaEmpleado_Click);
            // 
            // txtb_IdBaja
            // 
            this.txtb_IdBaja.Location = new System.Drawing.Point(43, 90);
            this.txtb_IdBaja.Name = "txtb_IdBaja";
            this.txtb_IdBaja.PlaceholderText = "Ingrese el ID del empleado";
            this.txtb_IdBaja.Size = new System.Drawing.Size(185, 23);
            this.txtb_IdBaja.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtb_IdBaja);
            this.groupBox3.Controls.Add(this.btn_BajaEmpleado);
            this.groupBox3.Controls.Add(this.lblId);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(409, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 191);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BAJAS";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nomina Empleados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Sueldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nº DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Apellido";
            // 
            // lstb_Nomina
            // 
            this.lstb_Nomina.FormattingEnabled = true;
            this.lstb_Nomina.ItemHeight = 15;
            this.lstb_Nomina.Location = new System.Drawing.Point(3, 247);
            this.lstb_Nomina.Name = "lstb_Nomina";
            this.lstb_Nomina.Size = new System.Drawing.Size(378, 244);
            this.lstb_Nomina.TabIndex = 6;
            // 
            // lblErrores
            // 
            this.lblErrores.BackColor = System.Drawing.Color.Red;
            this.lblErrores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrores.Location = new System.Drawing.Point(409, 87);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(170, 62);
            this.lblErrores.TabIndex = 51;
            this.lblErrores.Visible = false;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(775, 505);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lstb_Nomina);
            this.Controls.Add(this.btn_ModificarEmpleado);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AltaEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleados";
            this.Text = "Pet Shop Boys Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AltaEmpleado;
        private System.Windows.Forms.Button btn_ModificarEmpleado;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btn_BajaEmpleado;
        private System.Windows.Forms.TextBox txtb_IdBaja;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstb_Nomina;
        private System.Windows.Forms.Label lblErrores;
    }
}