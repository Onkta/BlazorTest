using System.Security.Cryptography;
using System.Xml.Schema;

namespace BlazorTest.Models
{
    public static class ServerRepository
    {

        private static List<Server> _servers = new List<Server>
        {
            new Server{ Name = "Server_1", City = "Karlsruhe", ServerID = 1},
            new Server{ Name = "Server_2", City = "Freiburg", ServerID = 2},
            new Server{ Name = "Server_3", City = "Berlin", ServerID = 3},
            new Server{ Name = "Server_4", City = "Karlsruhe", ServerID = 4},
            new Server{ Name = "Server_5", City = "Berlin", ServerID = 5},
            new Server{ Name = "Server_6", City = "Berlin", ServerID = 6},
            new Server{ Name = "Server_7", City = "Freiburg", ServerID = 7},
            new Server{ Name = "Server_8", City = "Karlsruhe", ServerID = 8},
            new Server{ Name = "Server_9", City = "Karlsruhe", ServerID = 9},
        };

        public static void UpdateServer(Server server)
        {
            var serverToUpdate = _servers.FirstOrDefault(s => s.ServerID == server.ServerID);

            serverToUpdate.Name = server.Name;
            serverToUpdate.City = server.City;
            serverToUpdate.IsOnline = server.IsOnline;
        }

        public static void AddServer(Server server)
        {
            var maxID = _servers.Max(s => s.ServerID);
            server.ServerID = maxID++;
            _servers.Add(server);
        }

        public static List<Server> GetServers()
            => _servers;

        public static List<Server> GetServerByCity(string city)
            => _servers.Where(s => s.City.Equals(city)).ToList();

        public static Server GetServerByID(int id)
        {
            var server = _servers.FirstOrDefault(s => s.ServerID == id);

            if (server == null) 
                return null;

            Server s1 = new Server
            {
                ServerID = server.ServerID,
                Name = server.Name,
                City = server.City,
                IsOnline = server.IsOnline,
            };

            return s1;
        }

        public static void DeleteServer(int id)
        {
            var server = _servers.FirstOrDefault(s => s.ServerID == id);

            if (server == null) return;

            _servers.Remove(server);
        }

        public static List<Server> FindServer(string searchString)
            => _servers.Where(s1 => s1.Name.Contains(searchString)).ToList();
    }
}
