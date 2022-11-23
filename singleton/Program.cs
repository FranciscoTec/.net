namespace EjemploSingle
{
    class MainApp
    {
        static void Main()
        {
            Singleton? instancia1 = Singleton.Instance();
            Singleton? instancia2 = Singleton.Instance();

            if (instancia1 == instancia2)
            {
                Console.WriteLine("Misma instancia");
            }

            Balancer lb1 = Balancer.GetLoadBalancer();
            Balancer lb2 = Balancer.GetLoadBalancer();
            Balancer lb3 = Balancer.GetLoadBalancer();
            Balancer lb4 = Balancer.GetLoadBalancer();

            if (lb1 == lb2 && lb2 == lb3 && lb3 == lb4)

            {
                Console.WriteLine("Son todas iguales\n");
            }

            Balancer balancer = Balancer.GetLoadBalancer();

            for (int i = 0; i < 5; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Pasar solicitud a : " + server);
            }

        }
    }
}