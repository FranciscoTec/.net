using MetodoFabrica02.Fabrica;
using MetodoFabrica02.Fabrica.Creadores;

namespace MetodoFabrica02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IDispositivo dispositivo;
            Console.WriteLine("Cual es tu presupuesto");
            //dato = Console.ReadLine();
            dato = "100000";
            dinero = Convert.ToInt32(dato);
            // Obtenemos el vehiculo de la fabrica
            dispositivo = CCreador.MetodoFabrica(dinero);
            dispositivo.Iniciar();
            dispositivo.Llamar();
            dispositivo.Colgar();
            dispositivo.Reiniciar();
        }
    }
}