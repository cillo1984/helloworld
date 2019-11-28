using System.Drawing;

using System.Windows.Forms;

namespace PolimorfismoInterfaces
{
    public partial class FrmVer : Form
    {
        public FrmVer(IElementoMultimedia pIElementoMultimedia)
        {
            InitializeComponent();
            
            switch(pIElementoMultimedia.GetType().Name)
            {
                case "Libro":
                    InicializarFrmLibro(pIElementoMultimedia);
                    break;
                case "Revista":
                    InicializarFrmRevista(pIElementoMultimedia);
                    break;
                case "CD":
                    InicializarFrmCD(pIElementoMultimedia);
                    break;
            }
        }

        private void InicializarFrmLibro(IElementoMultimedia pIElementoMultimedia)
        {
            // lblTitulo
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 50);
            lbl.Text = "Título";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // lblEditorial
            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 100);
            lbl.Text = "Editorial";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // lblISBN
            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 150);
            lbl.Text = "ISBN";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // lblResumen
            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 200);
            lbl.Text = "Resumen";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // txtBoxTitulo
            TextBox txtBox = new TextBox();
            txtBox.Text = pIElementoMultimedia.GetTitulo();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 20);
            txtBox.Location = new Point(200, 50);
            Controls.Add(txtBox);

            // txtBoxEditorial
            txtBox = new TextBox();
            txtBox.Text = ((Libro)pIElementoMultimedia).GetEditorial();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 20);
            txtBox.Location = new Point(200, 100);
            Controls.Add(txtBox);

            // txtBoxISBN
            txtBox = new TextBox();
            txtBox.Text = ((Libro)pIElementoMultimedia).GetISBN();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 20);
            txtBox.Location = new Point(200, 150);
            Controls.Add(txtBox);

            // txtBoxResumen
            txtBox = new TextBox();
            txtBox.Text = ((Libro)pIElementoMultimedia).GetResumen();
            txtBox.Multiline = true;
            txtBox.ScrollBars = ScrollBars.Vertical;
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 150);
            txtBox.Location = new Point(200, 200);
            Controls.Add(txtBox);

            // Propiedades del formulario.
            Size = new Size(640, 400);
            Text = "Datos del libro";
        }

        private void InicializarFrmRevista(IElementoMultimedia pIElementoMultimedia)
        {
            // lblTitulo
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 50);
            lbl.Text = "Título";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // lblEditorial
            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 100);
            lbl.Text = "Editorial";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // lblNúmero
            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 150);
            lbl.Text = "Número";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // lblFecha
            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 200);
            lbl.Text = "Fecha";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // lblPalabrasClave
            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 250);
            lbl.Text = "Palabras clave";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // txtBoxTitulo
            TextBox txtBox = new TextBox();
            txtBox.Text = pIElementoMultimedia.GetTitulo();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 20);
            txtBox.Location = new Point(220, 50);
            Controls.Add(txtBox);

            // txtBoxEditorial
            txtBox = new TextBox();
            txtBox.Text = ((Revista)pIElementoMultimedia).GetEditorial();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 20);
            txtBox.Location = new Point(220, 100);
            Controls.Add(txtBox);

            // txtBoxNumero
            txtBox = new TextBox();
            txtBox.Text = ((Revista)pIElementoMultimedia).GetNumero();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 20);
            txtBox.Location = new Point(220, 150);
            Controls.Add(txtBox);

            // txtBoxFecha
            txtBox = new TextBox();
            txtBox.Text = ((Revista)pIElementoMultimedia).GetFecha();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 150);
            txtBox.Location = new Point(220, 200);
            Controls.Add(txtBox);

            // txtBoxPalabrasClave
            txtBox = new TextBox();
            txtBox.Text = ((Revista)pIElementoMultimedia).GetPalabrasClave();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 150);
            txtBox.Location = new Point(220, 250);
            Controls.Add(txtBox);

            // Propiedades del formulario.
            Size = new Size(640, 400);
            Text = "Datos del libro";
        }

        private void InicializarFrmCD(IElementoMultimedia pIElementoMultimedia)
        {
            // lblTitulo
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 100);
            lbl.Text = "Título";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // lblDiscográfica
            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 200);
            lbl.Text = "Discográfica";
            lbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lbl);

            // txtBoxTitulo
            TextBox txtBox = new TextBox();
            txtBox.Text = pIElementoMultimedia.GetTitulo();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 20);
            txtBox.Location = new Point(200, 100);
            Controls.Add(txtBox);

            // txtBoxDiscográfica
            txtBox = new TextBox();
            txtBox.Text = ((CD)pIElementoMultimedia).GetDiscografica();
            txtBox.ReadOnly = true;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = 0;
            txtBox.Size = new Size(300, 20);
            txtBox.Location = new Point(200, 200);
            Controls.Add(txtBox);

            // Propiedades del formulario.
            Size = new Size(640, 400);
            Text = "Datos del libro";
        }
    }
}
