using classes;

namespace services
{
	class Broker
	{
		public void Start(int port = 8080)
		{
			// Server liegt in classes/server.cs und kann im selben Projekt direkt verwendet werden.
			Server.Main(port: port);
		}
	}
}
