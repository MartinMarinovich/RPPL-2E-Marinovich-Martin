﻿

namespace PetShopForms
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblLoginTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnLogInAdministrativo = new System.Windows.Forms.Button();
            this.txtb_Usuario = new System.Windows.Forms.TextBox();
            this.txtb_Contraseña = new System.Windows.Forms.TextBox();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.lstView_Nomina = new System.Windows.Forms.ListView();
            this.btn_CompletarComoEmpleado = new System.Windows.Forms.Button();
            this.btn_CompletarComoAdmin = new System.Windows.Forms.Button();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.btn_DarkMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.AutoSize = true;
            this.lblLoginTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginTitulo.Location = new System.Drawing.Point(-2, 9);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(377, 54);
            this.lblLoginTitulo.TabIndex = 0;
            this.lblLoginTitulo.Text = "Pet Shop Boys Store";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(42, 133);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.Location = new System.Drawing.Point(34, 210);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(88, 20);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnLogInAdministrativo
            // 
            this.btnLogInAdministrativo.Location = new System.Drawing.Point(128, 275);
            this.btnLogInAdministrativo.Name = "btnLogInAdministrativo";
            this.btnLogInAdministrativo.Size = new System.Drawing.Size(152, 36);
            this.btnLogInAdministrativo.TabIndex = 4;
            this.btnLogInAdministrativo.Text = "Ingresar";
            this.btnLogInAdministrativo.UseVisualStyleBackColor = true;
            this.btnLogInAdministrativo.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtb_Usuario
            // 
            this.txtb_Usuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtb_Usuario.ForeColor = System.Drawing.Color.Black;
            this.txtb_Usuario.Location = new System.Drawing.Point(128, 134);
            this.txtb_Usuario.Name = "txtb_Usuario";
            this.txtb_Usuario.PlaceholderText = "Ingresar usuario";
            this.txtb_Usuario.Size = new System.Drawing.Size(152, 23);
            this.txtb_Usuario.TabIndex = 5;
            // 
            // txtb_Contraseña
            // 
            this.txtb_Contraseña.Location = new System.Drawing.Point(128, 207);
            this.txtb_Contraseña.Name = "txtb_Contraseña";
            this.txtb_Contraseña.PasswordChar = '*';
            this.txtb_Contraseña.PlaceholderText = "Ingresar contraseña";
            this.txtb_Contraseña.Size = new System.Drawing.Size(151, 23);
            this.txtb_Contraseña.TabIndex = 6;
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTituloUsuario.Location = new System.Drawing.Point(780, 67);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(134, 27);
            this.lblTituloUsuario.TabIndex = 11;
            this.lblTituloUsuario.Text = "Panel de usuarios";
            // 
            // lstView_Nomina
            // 
            this.lstView_Nomina.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstView_Nomina.HideSelection = false;
            this.lstView_Nomina.Location = new System.Drawing.Point(334, 97);
            this.lstView_Nomina.Name = "lstView_Nomina";
            this.lstView_Nomina.Size = new System.Drawing.Size(620, 356);
            this.lstView_Nomina.TabIndex = 12;
            this.lstView_Nomina.UseCompatibleStateImageBehavior = false;
            // 
            // btn_CompletarComoEmpleado
            // 
            this.btn_CompletarComoEmpleado.Location = new System.Drawing.Point(128, 332);
            this.btn_CompletarComoEmpleado.Name = "btn_CompletarComoEmpleado";
            this.btn_CompletarComoEmpleado.Size = new System.Drawing.Size(152, 34);
            this.btn_CompletarComoEmpleado.TabIndex = 13;
            this.btn_CompletarComoEmpleado.Text = "Ingresar como empleado";
            this.btn_CompletarComoEmpleado.UseVisualStyleBackColor = true;
            this.btn_CompletarComoEmpleado.Click += new System.EventHandler(this.btn_CompletarComoEmpleado_Click);
            // 
            // btn_CompletarComoAdmin
            // 
            this.btn_CompletarComoAdmin.Location = new System.Drawing.Point(128, 384);
            this.btn_CompletarComoAdmin.Name = "btn_CompletarComoAdmin";
            this.btn_CompletarComoAdmin.Size = new System.Drawing.Size(151, 34);
            this.btn_CompletarComoAdmin.TabIndex = 14;
            this.btn_CompletarComoAdmin.Text = "Ingresar como Admin";
            this.btn_CompletarComoAdmin.UseVisualStyleBackColor = true;
            this.btn_CompletarComoAdmin.Click += new System.EventHandler(this.btn_CompletarComoAdmin_Click);
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.BackColor = System.Drawing.Color.Red;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblErrorUsuario.Location = new System.Drawing.Point(12, 441);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(193, 39);
            this.lblErrorUsuario.TabIndex = 15;
            // 
            // btn_DarkMode
            // 
            this.btn_DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_DarkMode.Location = new System.Drawing.Point(546, 12);
            this.btn_DarkMode.Name = "btn_DarkMode";
            this.btn_DarkMode.Size = new System.Drawing.Size(93, 27);
            this.btn_DarkMode.TabIndex = 16;
            this.btn_DarkMode.Text = "Dark Mode";
            this.btn_DarkMode.UseVisualStyleBackColor = false;
            this.btn_DarkMode.Click += new System.EventHandler(this.btn_DarkMode_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1034, 497);
            this.Controls.Add(this.btn_DarkMode);
            this.Controls.Add(this.lblErrorUsuario);
            this.Controls.Add(this.btn_CompletarComoAdmin);
            this.Controls.Add(this.btn_CompletarComoEmpleado);
            this.Controls.Add(this.lstView_Nomina);
            this.Controls.Add(this.lblTituloUsuario);
            this.Controls.Add(this.txtb_Contraseña);
            this.Controls.Add(this.txtb_Usuario);
            this.Controls.Add(this.btnLogInAdministrativo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblLoginTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop Boys ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnLogInAdministrativo;
        private System.Windows.Forms.TextBox txtb_Usuario;
        private System.Windows.Forms.TextBox txtb_Contraseña;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.ListView lstView_Nomina;
        private System.Windows.Forms.Button btn_CompletarComoEmpleado;
        private System.Windows.Forms.Button btn_CompletarComoAdmin;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.Button btn_DarkMode;
    }
}

