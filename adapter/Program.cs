using System;

namespace EjemploAdap.AdapterReal
{

    class MainApp
    {

        static void Main()
        {

            Pelicula desconocido = new Pelicula("Desconocido");

            desconocido.MostrarInfo();

            Pelicula l1 = new InformacionPelicula("L01");
            l1.MostrarInfo();

            Pelicula l2 = new InformacionPelicula("L02");
            l2.MostrarInfo();

            Pelicula l3 = new InformacionPelicula("L03");
            l3.MostrarInfo();

            Console.ReadKey();

        }

    }

    class Pelicula
    {
        protected string _codigo;

        protected string _autor;

        protected string _titulo;

        protected string _productora;

        protected string _isan;

        public Pelicula(string codigo)
        {
            this._codigo = codigo;
        }

        public virtual void MostrarInfo()
        {

            Console.WriteLine("\nPelicula: {0} ------ ", _codigo);

        }

    }

    class InformacionPelicula : Pelicula
    {

        private Videoclub _vc;

        public InformacionPelicula(string codigo) : base(codigo)
        {
            Console.WriteLine(codigo);

        }

        public override void MostrarInfo()
        {

            _vc = new Videoclub();


            _autor = _vc.ObtenerAutor(_codigo);

            _titulo = _vc.ObtenerTitulo(_codigo);

            _productora = _vc.ObtenerProductora(_codigo);

            _isan = _vc.ObtenerISAN(_codigo);


            base.MostrarInfo();

            Console.WriteLine(" Título: {0}", _titulo);

            Console.WriteLine(" Autor: {0}", _autor);

            Console.WriteLine(" Productora: {0}", _productora);

            Console.WriteLine(" ISAN: {0}", _isan);
        }
    }

    class Videoclub
    {

        public string ObtenerAutor(string pelicula)
        {

            switch (pelicula)
            {

                case "P01": return "Valentina Juarez";

                case "P02": return "Carlos Vermunt";

                case "P03": return "Cristopher Nolan";

                default: return "";
            }

        }

        public string ObtenerTitulo(string pelicula)
        {
            switch (pelicula)
            {
                case "P01": return "Animales de los bosques de coniferas";

                case "P02": return "Magical girl";

                case "P03": return "Interstellar";

                default: return "";
            }
        }

        public string ObtenerProductora(string pelicula)
        {
            switch (pelicula)
            {
                case "P01": return "Luces dominicanas";

                case "P02": return "Aqui y Alli Films";

                case "P03": return "Paramount Pictures";

                default: return "";
            }
        }

        public string ObtenerISAN(string pelicula)
        {
            switch (pelicula)
            {
                case "P01": return "89237532985";

                case "P02": return "938573985439";

                case "P03": return "9835798572395";

                default: return "";
            }
        }

    }

}


