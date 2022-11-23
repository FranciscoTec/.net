
namespace EjemploProt.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CAdminPrototipos admin = new CAdminPrototipos();

            CCliente uno = (CCliente)admin.ObtenPrototipo("Persona");
            CCliente dos = (CCliente)admin.ObtenPrototipo("Persona");

            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            uno.Nombre = "Maria";
            dos.Nombre = "Victor";

            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            CPC auto = new CPC("MSI", 20);

            admin.AdicionaPrototipo("PC", auto);

            CPC auto2 = (CPC)admin.ObtenPrototipo("PC");

            auto2.Serie = "NZXT";

            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("-----");

            CValores val = (CValores)admin.ObtenPrototipo("Valores");
            Console.WriteLine(val);
        }

    }
}