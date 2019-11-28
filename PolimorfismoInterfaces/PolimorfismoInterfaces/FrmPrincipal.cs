using System;

using System.Collections;

using System.Windows.Forms;

namespace PolimorfismoInterfaces
{
    public partial class FrmPrincipal : Form
    {
        /* Objeto. */
        // Atributos.
        ArrayList AlIElementoMultimedia;

        // Constructores.
        /**
         * Constructor por defecto.
         */
        public FrmPrincipal()
        {
            InitializeComponent();
            AlIElementoMultimedia = new ArrayList();
            InicializacionDinamica();
        }

        // Métodos.
        private void InicializacionDinamica()
        {
            AlIElementoMultimedia.Add(new Libro("El ingenioso hidalgo Don Quijote de la Mancha", "akal",
                "978-84-460-4319-5", "El ingenioso hidalgo don Quijote de la Mancha narra las aventuras de Alonso" +
                " Quijano, un hidalgo pobre que de tanto leer novelas de caballería acaba enloqueciendo y " +
                "creyendo ser un caballero andante, nombrándose a sí mismo como don Quijote de la Mancha. " +
                "Sus intenciones son ayudar a los pobres y desfavorecidos, y lograr el amor de la supuesta " +
                "Dulcinea del Toboso, que es en realidad es una campesina llamada Aldonza Lorenzo. Decide nombrar " +
                "a Sancho Panza, un empleado suyo, su escudero. Juntos viven muchas aventuras y tras ser vencido por " +
                "el Caballero de la Blanca Luna se retira a su hogar, donde, tras adquirir de nuevo la cordura, fallece. " +
                "La presente edición intenta no ser una más de las múltiples ediciones existentes.Se ha respetado el " +
                "texto de la edición príncipe con el mayor escrúpulo posible, acompañada de notas explicativas. " +
                "Está ilustrada con magníficos grabados españoles que acompañaron a la primera edición de la Academia. " +
                "Una edición en suma, tal como se dice en la introducción, realizada a la medida de todos los lectores" +
                " y capaz de sugerir más de una interpretación."));

            string[] aPalabrasClave1 = { "videojuegos", "análisis", "avances", "retro", "demostración",
                "nba", "2k20", "control", "gears" , "switch" };
            AlIElementoMultimedia.Add(new Revista("Hobby Consolas", 339, aPalabrasClave1, "01/11/2019", "Axel Springer"));

            string[] aPalabrasClave2 = { "videojuegos", "análisis", "avances", "retro", "nintendo", "mario",
                "pokémon", "super", "switch" };
            AlIElementoMultimedia.Add(new Revista("Revista Oficial Nintendo", 316, aPalabrasClave2, "01/11/2019",
                "Axel Springer"));

            AlIElementoMultimedia.Add(new CD("El Danzar de las Mariposas", "Concert Music Entertainmnent"));
        }

        private void MenuStripItems_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Alta":
                    CargarFormAlta();
                    break;
                case "Consulta":
                    CargarFormConsulta();
                    break;
                case "Salir":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private void CargarFormAlta()
        {
            int cont = 0;
            foreach(Form fForm in MdiChildren)
            {
                if ((fForm.Name.Equals("FrmAlta")) && (cont == 0))
                {
                    fForm.Show();                    
                    cont++;
                } else
                {
                    fForm.Hide();
                }
            }

            if (cont == 0)
            {
                FrmAlta frmAlta = new FrmAlta(AlIElementoMultimedia);
                frmAlta.MdiParent = this;
                frmAlta.Dock = DockStyle.Fill;
                frmAlta.Show();
            }
        }

        private void CargarFormConsulta()
        {
            int cont = 0;
            foreach (Form fForm in MdiChildren)
            {
                if ((fForm.Name.Equals("FrmConsulta")) && (cont == 0))
                {
                    fForm.Show();
                    cont++;
                }
                else
                {
                    fForm.Hide();
                }
            }

            if (cont == 0)
            {
                FrmConsulta frmConsulta = new FrmConsulta(AlIElementoMultimedia);
                frmConsulta.MdiParent = this;
                frmConsulta.Dock = DockStyle.Fill;
                frmConsulta.Show();
            }
        }
    }
}
