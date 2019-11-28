using System;

namespace PolimorfismoInterfaces
{
    class Revista : IElementoMultimedia, IComparable
    {
        /* Objeto. */
        // Atributos.
        private string Titulo;
        private int Numero;
        private string[] APalabrasClave;
        private string Fecha;
        private string Editorial;

        // Constructores.
        /**
         * Constructor a partir de todos los atributos.
         */
        public Revista(string pTitulo, int pNumero, string[] pAPalabrasClave, string pFecha, string pEditorial)
        {
            Titulo = pTitulo;
            Numero = pNumero;
            APalabrasClave = pAPalabrasClave;
            Fecha = pFecha;
            Editorial = pEditorial;
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

        public string GetNumero()
        {
            return Convert.ToString(Numero);
        }

        public string GetPalabrasClave()
        {
            string rPalabrasClave = "";

            foreach (string fString in APalabrasClave)
            {
                rPalabrasClave += fString + " ";
            }

            rPalabrasClave = rPalabrasClave.Trim();

            return rPalabrasClave;
        }

        public string GetFecha()
        {
            return Fecha;
        }

        // Métodos.
        public void Mostrar()
        {
            FrmVer frmVer = new FrmVer(this);
            frmVer.Show();
        }

        public bool EsValido(string pTextoABuscar)
        {
            string[] aPalabras = pTextoABuscar.Split(' ');
            foreach (string fString in aPalabras)
            {
                foreach (string fPalabra in APalabrasClave)
                {
                    if (fString.ToLower().Equals(fPalabra.ToLower()))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int CompareTo(object pObject)
        {
            return (Titulo.CompareTo(((IElementoMultimedia)pObject).GetTitulo()));
        }
    }
}
