using System;

namespace PolimorfismoInterfaces
{
    class Libro : IElementoMultimedia, IComparable
    {
        /* Objeto. */
        // Atributos.
        private string Titulo;
        private string Editorial;
        private string ISBN;
        private string Resumen;

        // Constructores.
        /**
         * Constructor a partir de todos los atributos.
         */
        public Libro(string pTitulo, string pEditorial, string pISBN, string pResumen)
        {
            Titulo = pTitulo;
            Editorial = pEditorial;
            ISBN = pISBN;
            Resumen = pResumen;
        }

        // Getters.
        public string GetTitulo()
        {
            return Titulo;
        }

        public string GetEditorial()
        {
            return Editorial;
        }

        public string GetISBN()
        {
            return ISBN;
        }

        public string GetResumen()
        {
            return Resumen;
        }

        // Métodos.
        public void Mostrar()
        {
            FrmVer frmVer = new FrmVer(this);
            frmVer.ShowDialog();
        }

        public bool EsValido(string pTextoABuscar)
        {
            return Resumen.ToLower().Contains(pTextoABuscar.ToLower());
        }

        public int CompareTo(object pObject)
        {
            return (Titulo.CompareTo(((IElementoMultimedia)pObject).GetTitulo()));
        }
    }
}
