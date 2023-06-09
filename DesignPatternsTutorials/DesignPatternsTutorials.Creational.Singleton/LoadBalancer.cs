namespace DesignPatternsTutorials.Creational.Singleton;

public sealed class LoadBalancer
{
    private static readonly LoadBalancer _instance = new LoadBalancer();
    private List<Server> _servers;
    private Random _random = new Random();

    private LoadBalancer()
    {
        _servers = new List<Server>()
        {
            new Server(){IP = "192.168.0.1", Name = "Server 1"},
            new Server(){IP = "192.168.0.2", Name = "Server 2"},
            new Server(){IP = "192.168.0.3", Name = "Server 3"},
            new Server(){IP = "192.168.0.4", Name = "Server 4"},
            new Server(){IP = "192.168.0.5", Name = "Server 5"}
        };
    }

    public static LoadBalancer GetLoadBalancer()
    {
        return _instance;
    }

    public Server NextServer
    {
        get
        {
            int next = _random.Next(_servers.Count);
            return _servers[next];
        }
    }
}