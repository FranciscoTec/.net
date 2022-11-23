namespace EjemploSingle
{
    class Balancer
    {
        private static Balancer? _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();
        private static object syncLock = new object();
        protected Balancer()
        {
            _servers.Add("Server 1");
            _servers.Add("Server 2");
            _servers.Add("Server 3");
            _servers.Add("Server 4");
            _servers.Add("Server 5");
        }
        public static Balancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Balancer();
                    }
                }
                Console.WriteLine(syncLock.ToString());
            }
            return _instance;
        }
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}