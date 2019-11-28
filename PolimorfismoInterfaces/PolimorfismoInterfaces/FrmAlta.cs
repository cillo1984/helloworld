using System;

using System.Collections;

using System.Windows.Forms;

namespace PolimorfismoInterfaces
{
    public partial class FrmAlta : Form
    {
        /* Objeto. */
        // Atributos.
        ArrayList AlIElementoMultimedia;

        // Constructores.
        /**
         * Constructor a partir del atributo.
         */
        public FrmAlta(ArrayList pALIElementoMultimedia)
        {
            InitializeComponent();
            AlIElementoMultimedia = pALIElementoMultimedia;
        }

        // Métodos.
        private void Botones_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Guardar":
                    Guardar();
                    break;
                case "Limpiar":
                    Limpiar();
                    break;
                default:
                    break;
            }
        }

        private void RdoBtnLibro_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();

            Lbl2.Text = "Editorial";
            Lbl3.Text = "ISBN";
            Lbl4.Text = "Resumen";

            Lbl2.Visible = true;
            Lbl3.Visible = true;
            Lbl4.Visible = true;

            TxtBox3.Visible = true;
            TxtBox4.Visible = true;

            TxtBox4.Multiline = true;
            TxtBox4.Size = new System.Drawing.Size(200, 100);

            Lbl5.Visible = false;

            TxtBox5.Visible = false;
        }

        private void RdoBtnRevista_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();

            Lbl2.Text = "Editorial";
            Lbl3.Text = "Número";
            Lbl4.Text = "Fecha";

            Lbl3.Visible = true;
            Lbl4.Visible = true;
            Lbl5.Visible = true;

            TxtBox3.Visible = true;
            TxtBox4.Visible = true;

            TxtBox4.Multiline = false;

            TxtBox5.Visible = true;
        }

        private void RdoBtnCD_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();

            Lbl2.Text = "Discográfica";

            Lbl3.Visible = false;
            Lbl4.Visible = false;
            Lbl5.Visible = false;

            TxtBox3.Visible = false;
            TxtBox4.Visible = false;
            TxtBox5.Visible = false;
        }

        private void Limpiar()
        {
            TxtBox1.Clear();
            TxtBox2.Clear();
            TxtBox3.Clear();
            TxtBox4.Clear();
            TxtBox5.Clear();
        }

        private void Guardar()
        {
            if (RdoBtnLibro.Checked)
            {
                GuardarLibro();
            } else if (RdoBtnRevista.Checked)
            {
                GuardarRevista();
            } else if (RdoBtnCD.Checked)
            {
                GuardarCD();
            }
        }

        private void GuardarLibro()
        {
            if ((TxtBox1.TextLength == 0) || (TxtBox2.TextLength == 0) || (TxtBox3.TextLength == 0)
                || (TxtBox4.TextLength == 0))
            {
                MessageBox.Show("Hay campos sin rellenar.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                AlIElementoMultimedia.Add(new Libro(TxtBox1.Text, TxtBox2.Text, TxtBox3.Text,
                    TxtBox4.Text));
                AlIElementoMultimedia.Sort();
                Limpiar();
            }
        }

        private void GuardarRevista()
        {
            if ((TxtBox1.TextLength == 0) || (TxtBox2.TextLength == 0) || (TxtBox3.TextLength == 0)
                || (TxtBox4.TextLength == 0) || (TxtBox5.TextLength == 0))
            {
                MessageBox.Show("Hay campos sin rellenar.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AlIElementoMultimedia.Add(new Revista(TxtBox1.Text, Convert.ToInt32(TxtBox3.Text), TxtBox5.Text.Split(' '),
                    TxtBox4.Text, TxtBox2.Text));
                AlIElementoMultimedia.Sort();
                Limpiar();
            }
        }

        private void GuardarCD()
        {
            if ((TxtBox1.TextLength == 0) || (TxtBox2.TextLength == 0))
            {
                MessageBox.Show("Hay campos sin rellenar.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AlIElementoMultimedia.Add(new CD(TxtBox1.Text, TxtBox2.Text));
                AlIElementoMultimedia.Sort();
                Limpiar();
            }
        }
    }
}
