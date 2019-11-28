namespace PolimorfismoInterfaces
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MnuStp = new System.Windows.Forms.MenuStrip();
            this.TolStpMnuItmAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.TolStpMnuItmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TolStpMnuItmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStp
            // 
            this.MnuStp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TolStpMnuItmAlta,
            this.TolStpMnuItmConsulta,
            this.TolStpMnuItmSalir});
            this.MnuStp.Location = new System.Drawing.Point(0, 0);
            this.MnuStp.Name = "MnuStp";
            this.MnuStp.Size = new System.Drawing.Size(784, 24);
            this.MnuStp.TabIndex = 1;
            // 
            // TolStpMnuItmAlta
            // 
            this.TolStpMnuItmAlta.Name = "TolStpMnuItmAlta";
            this.TolStpMnuItmAlta.Size = new System.Drawing.Size(40, 20);
            this.TolStpMnuItmAlta.Text = "Alta";
            this.TolStpMnuItmAlta.Click += new System.EventHandler(this.MenuStripItems_Click);
            // 
            // TolStpMnuItmConsulta
            // 
            this.TolStpMnuItmConsulta.Name = "TolStpMnuItmConsulta";
            this.TolStpMnuItmConsulta.Size = new System.Drawing.Size(66, 20);
            this.TolStpMnuItmConsulta.Text = "Consulta";
            this.TolStpMnuItmConsulta.Click += new System.EventHandler(this.MenuStripItems_Click);
            // 
            // TolStpMnuItmSalir
            // 
            this.TolStpMnuItmSalir.Name = "TolStpMnuItmSalir";
            this.TolStpMnuItmSalir.Size = new System.Drawing.Size(41, 20);
            this.TolStpMnuItmSalir.Text = "Salir";
            this.TolStpMnuItmSalir.Click += new System.EventHandler(this.MenuStripItems_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MnuStp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuStp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Multimedia";
            this.MnuStp.ResumeLayout(false);
            this.MnuStp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStp;
        private System.Windows.Forms.ToolStripMenuItem TolStpMnuItmAlta;
        private System.Windows.Forms.ToolStripMenuItem TolStpMnuItmConsulta;
        private System.Windows.Forms.ToolStripMenuItem TolStpMnuItmSalir;
    }
}

