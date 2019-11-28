using System;

namespace PolimorfismoInterfaces
{
    class CD : IElementoMultimedia, IComparable
    {
        /* Objetos. */
        // Atributos.
        private string Titulo;
        private string Discografica;

        // Constructores.
        /**
         * Constructor a partir de los atributos.
         */
        public CD(string pTitulo, string pDiscografica)
        {
            Titulo = pTitulo;
            Discografica = pDiscografica;
        }

        // Getters.
        public string GetTitulo()
        {
            return Titulo;
        }

        public string GetDiscografica()
        {
            return Discografica;
        }

        // Métodos
        public void Mostrar()
        {
            FrmVer frmVer = new FrmVer(this);
            frmVer.Show();
        }

        public bool EsValido(string pTextoABuscar)
        {
            return Titulo.ToLower().Equals(pTextoABuscar.ToLower());
        }

        public int CompareTo(object pObject)
        {
            return (Titulo.CompareTo(((IElementoMultimedia)pObject).GetTitulo()));
        }
    }
}
