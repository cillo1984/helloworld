namespace PolimorfismoInterfaces
{
    public interface IElementoMultimedia
    {
        // Métodos.
        bool EsValido(string pTextoABuscar);

        void Mostrar();

        string GetTitulo();
    }
}
