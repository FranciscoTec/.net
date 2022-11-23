namespace MetodoFabrica02.Fabrica.Creadores
{
    internal class CCreador
    {
        internal static IDispositivo MetodoFabrica(int dinero)
        {
            IDispositivo temp = null;

            if (dinero > 1000)
            {
                temp = new CTelefono();
            }
            return temp;
        }

    }
}