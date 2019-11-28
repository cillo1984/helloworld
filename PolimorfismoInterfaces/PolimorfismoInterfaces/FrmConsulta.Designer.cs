namespace PolimorfismoInterfaces
{
    partial class FrmConsulta
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
            this.LblTextoABuscar = new System.Windows.Forms.Label();
            this.TxtBoxTextoABuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LstViw = new System.Windows.Forms.ListView();
            this.ClmHeaderTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHeaderTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LblTextoABuscar
            // 
            this.LblTextoABuscar.AutoSize = true;
            this.LblTextoABuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextoABuscar.Location = new System.Drawing.Point(45, 40);
            this.LblTextoABuscar.Name = "LblTextoABuscar";
            this.LblTextoABuscar.Size = new System.Drawing.Size(121, 17);
            this.LblTextoABuscar.TabIndex = 0;
            this.LblTextoABuscar.Text = "Texto a buscar:";
            // 
            // TxtBoxTextoABuscar
            // 
            this.TxtBoxTextoABuscar.Location = new System.Drawing.Point(180, 40);
            this.TxtBoxTextoABuscar.Name = "TxtBoxTextoABuscar";
            this.TxtBoxTextoABuscar.Size = new System.Drawing.Size(250, 20);
            this.TxtBoxTextoABuscar.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(485, 40);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LstViw
            // 
            this.LstViw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmHeaderTitulo,
            this.ClmHeaderTipo});
            this.LstViw.HideSelection = false;
            this.LstViw.Location = new System.Drawing.Point(45, 100);
            this.LstViw.MultiSelect = false;
            this.LstViw.Name = "LstViw";
            this.LstViw.Size = new System.Drawing.Size(515, 300);
            this.LstViw.TabIndex = 3;
            this.LstViw.UseCompatibleStateImageBehavior = false;
            this.LstViw.View = System.Windows.Forms.View.Details;
            this.LstViw.DoubleClick += new System.EventHandler(this.LstViw_DoubleClick);
            // 
            // ClmHeaderTitulo
            // 
            this.ClmHeaderTitulo.Text = "Título";
            this.ClmHeaderTitulo.Width = 350;
            // 
            // ClmHeaderTipo
            // 
            this.ClmHeaderTipo.Text = "Tipo";
            this.ClmHeaderTipo.Width = 175;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.LstViw);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBoxTextoABuscar);
            this.Controls.Add(this.LblTextoABuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de elementos multimedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTextoABuscar;
        private System.Windows.Forms.TextBox TxtBoxTextoABuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ListView LstViw;
        private System.Windows.Forms.ColumnHeader ClmHeaderTitulo;
        private System.Windows.Forms.ColumnHeader ClmHeaderTipo;
    }
}