namespace EjemploProt.Prototype
{
    class CPC : IPrototipo
    {
        private string serie;
        private int costo;

        public string Serie { get => serie; set => serie = value; }

        public CPC(string pModelo, int pCosto)
        {
            serie = pModelo;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", serie, costo);
        }
        public object Clonar()
        {
            CPC clon = new CPC(serie, costo);

            return clon;
        }

    }
}