
namespace PetShopForms
{
    partial class FrmHistorialVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialVentas));
            this.label7 = new System.Windows.Forms.Label();
            this.lstb_HistorialVentas = new System.Windows.Forms.ListBox();
            this.lbl_MontoHistorico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 44);
            this.label7.TabIndex = 9;
            this.label7.Text = "Historial  De Ventas";
            // 
            // lstb_HistorialVentas
            // 
            this.lstb_HistorialVentas.FormattingEnabled = true;
            this.lstb_HistorialVentas.ItemHeight = 15;
            this.lstb_HistorialVentas.Location = new System.Drawing.Point(12, 56);
            this.lstb_HistorialVentas.Name = "lstb_HistorialVentas";
            this.lstb_HistorialVentas.Size = new System.Drawing.Size(930, 454);
            this.lstb_HistorialVentas.TabIndex = 10;
            // 
            // lbl_MontoHistorico
            // 
            this.lbl_MontoHistorico.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MontoHistorico.Location = new System.Drawing.Point(12, 522);
            this.lbl_MontoHistorico.Name = "lbl_MontoHistorico";
            this.lbl_MontoHistorico.Size = new System.Drawing.Size(567, 44);
            this.lbl_MontoHistorico.TabIndex = 11;
            // 
            // FrmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.lbl_MontoHistorico);
            this.Controls.Add(this.lstb_HistorialVentas);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHistorialVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de Ventas";
            this.Load += new System.EventHandler(this.FrmHistorialVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstb_HistorialVentas;
        private System.Windows.Forms.Label lbl_MontoHistorico;
    }
}