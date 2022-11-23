namespace EjemploProt.Prototype
{
    class CCliente : IPrototipo
    {

        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }

        public CCliente(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, edad);
        }
        public object Clonar()
        {
            CCliente clon = new CCliente(nombre, edad);

            return clon;
        }

    }
}