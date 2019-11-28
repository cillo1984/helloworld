using System;

using System.Collections;

using System.Windows.Forms;

namespace PolimorfismoInterfaces
{
    public partial class FrmConsulta : Form
    {
        /* Objeto. */
        // Atributos.
        ArrayList AlIElementoMultimedia;

        // Constructores.
        /**
         * Constructor a partir del atributo.
         */
        public FrmConsulta(ArrayList pALIElementoMultimedia)
        {
            InitializeComponent();
            AlIElementoMultimedia = pALIElementoMultimedia;
        }

        // Métodos.
        private void BtnBuscar_Click(object sender, System.EventArgs e)
        {
            LstViw.Items.Clear();

            int cont = 0;
            foreach (IElementoMultimedia fIElementoMultimedia in AlIElementoMultimedia)
            {
                if (!TxtBoxTextoABuscar.Text.Equals(""))
                {
                    if (fIElementoMultimedia.EsValido(TxtBoxTextoABuscar.Text))
                    {
                        ListViewItem listViewItem = LstViw.Items.Add(fIElementoMultimedia.GetTitulo());
                        listViewItem.Tag = cont;
                        listViewItem.SubItems.Add(fIElementoMultimedia.GetType().Name);
                    }
                }

                cont++;
            }
        }

        private void LstViw_DoubleClick(object sender, System.EventArgs e)
        {
            ((IElementoMultimedia)AlIElementoMultimedia[Convert
                .ToInt32(LstViw.SelectedItems[0].Tag.ToString())]).Mostrar();
        }
    }
}
