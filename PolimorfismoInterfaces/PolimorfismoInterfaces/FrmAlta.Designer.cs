namespace PolimorfismoInterfaces
{
    partial class FrmAlta
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
            this.GrpBoxTitulo = new System.Windows.Forms.GroupBox();
            this.RdoBtnCD = new System.Windows.Forms.RadioButton();
            this.RdoBtnRevista = new System.Windows.Forms.RadioButton();
            this.RdoBtnLibro = new System.Windows.Forms.RadioButton();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.TxtBox3 = new System.Windows.Forms.TextBox();
            this.TxtBox4 = new System.Windows.Forms.TextBox();
            this.TxtBox5 = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.GrpBoxTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxTitulo
            // 
            this.GrpBoxTitulo.Controls.Add(this.RdoBtnCD);
            this.GrpBoxTitulo.Controls.Add(this.RdoBtnRevista);
            this.GrpBoxTitulo.Controls.Add(this.RdoBtnLibro);
            this.GrpBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxTitulo.Location = new System.Drawing.Point(20, 20);
            this.GrpBoxTitulo.Name = "GrpBoxTitulo";
            this.GrpBoxTitulo.Size = new System.Drawing.Size(175, 175);
            this.GrpBoxTitulo.TabIndex = 0;
            this.GrpBoxTitulo.TabStop = false;
            this.GrpBoxTitulo.Text = "Tipo";
            // 
            // RdoBtnCD
            // 
            this.RdoBtnCD.AutoSize = true;
            this.RdoBtnCD.Location = new System.Drawing.Point(25, 130);
            this.RdoBtnCD.Name = "RdoBtnCD";
            this.RdoBtnCD.Size = new System.Drawing.Size(50, 22);
            this.RdoBtnCD.TabIndex = 2;
            this.RdoBtnCD.TabStop = true;
            this.RdoBtnCD.Text = "CD";
            this.RdoBtnCD.UseVisualStyleBackColor = true;
            this.RdoBtnCD.CheckedChanged += new System.EventHandler(this.RdoBtnCD_CheckedChanged);
            // 
            // RdoBtnRevista
            // 
            this.RdoBtnRevista.AutoSize = true;
            this.RdoBtnRevista.Location = new System.Drawing.Point(25, 90);
            this.RdoBtnRevista.Name = "RdoBtnRevista";
            this.RdoBtnRevista.Size = new System.Drawing.Size(82, 22);
            this.RdoBtnRevista.TabIndex = 1;
            this.RdoBtnRevista.TabStop = true;
            this.RdoBtnRevista.Text = "Revista";
            this.RdoBtnRevista.UseVisualStyleBackColor = true;
            this.RdoBtnRevista.CheckedChanged += new System.EventHandler(this.RdoBtnRevista_CheckedChanged);
            // 
            // RdoBtnLibro
            // 
            this.RdoBtnLibro.AutoSize = true;
            this.RdoBtnLibro.Location = new System.Drawing.Point(25, 50);
            this.RdoBtnLibro.Name = "RdoBtnLibro";
            this.RdoBtnLibro.Size = new System.Drawing.Size(64, 22);
            this.RdoBtnLibro.TabIndex = 0;
            this.RdoBtnLibro.TabStop = true;
            this.RdoBtnLibro.Text = "Libro";
            this.RdoBtnLibro.UseVisualStyleBackColor = true;
            this.RdoBtnLibro.CheckedChanged += new System.EventHandler(this.RdoBtnLibro_CheckedChanged);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(280, 50);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(43, 17);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "Título";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(280, 100);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(59, 17);
            this.Lbl2.TabIndex = 2;
            this.Lbl2.Text = "Editorial";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(280, 150);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(39, 17);
            this.Lbl3.TabIndex = 3;
            this.Lbl3.Text = "ISBN";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(280, 200);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(68, 17);
            this.Lbl4.TabIndex = 4;
            this.Lbl4.Text = "Resumen";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.Location = new System.Drawing.Point(280, 250);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(101, 17);
            this.Lbl5.TabIndex = 5;
            this.Lbl5.Text = "Palabras clave";
            this.Lbl5.Visible = false;
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(390, 49);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(200, 20);
            this.TxtBox1.TabIndex = 6;
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(390, 99);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(200, 20);
            this.TxtBox2.TabIndex = 7;
            // 
            // TxtBox3
            // 
            this.TxtBox3.Location = new System.Drawing.Point(390, 149);
            this.TxtBox3.Name = "TxtBox3";
            this.TxtBox3.Size = new System.Drawing.Size(200, 20);
            this.TxtBox3.TabIndex = 8;
            // 
            // TxtBox4
            // 
            this.TxtBox4.Location = new System.Drawing.Point(390, 199);
            this.TxtBox4.Multiline = true;
            this.TxtBox4.Name = "TxtBox4";
            this.TxtBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBox4.Size = new System.Drawing.Size(200, 100);
            this.TxtBox4.TabIndex = 9;
            // 
            // TxtBox5
            // 
            this.TxtBox5.Location = new System.Drawing.Point(390, 249);
            this.TxtBox5.Name = "TxtBox5";
            this.TxtBox5.Size = new System.Drawing.Size(200, 20);
            this.TxtBox5.TabIndex = 10;
            this.TxtBox5.Visible = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(390, 350);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.Botones_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(515, 350);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.Botones_Click);
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtBox5);
            this.Controls.Add(this.TxtBox4);
            this.Controls.Add(this.TxtBox3);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.GrpBoxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de elementos multimedia";
            this.GrpBoxTitulo.ResumeLayout(false);
            this.GrpBoxTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxTitulo;
        private System.Windows.Forms.RadioButton RdoBtnLibro;
        private System.Windows.Forms.RadioButton RdoBtnRevista;
        private System.Windows.Forms.RadioButton RdoBtnCD;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.TextBox TxtBox2;
        private System.Windows.Forms.TextBox TxtBox3;
        private System.Windows.Forms.TextBox TxtBox4;
        private System.Windows.Forms.TextBox TxtBox5;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}