using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HybridEmu.Core.Connection
{
    class ServerBootstrap
    {
        private AppServer Sock;
        private HashSet<int> acceptedConnections;
        private int countConnections;

        // <summary>
        // Initialiseert een socket verbinding.
        // </summary>
        // <param id="bindPort">De poort van de game server.</param>
        // <param id="acceptedConnections">Aantal verbindingen die hij totaal accepteert.</param>
        public void Init(int bindPort)
        {
            Sock = new AppServer();
            acceptedConnections = new HashSet<int>();

            if (!Sock.Setup(bindPort))
            {
                Console.WriteLine("Socketverbinding kan niet luisteren op poort " + bindPort);
                Console.ReadKey();

                return;
            }

            if (!Sock.Start())
            {
                Console.WriteLine("Socketverbinding kon niet worden gestart omdat deze poort al in gebruik is.");
                Console.ReadKey();

                return;
            }

            Console.WriteLine("Socketserver is succesvol gestart op poort " + bindPort);

            Sock.NewRequestReceived += new RequestHandler<AppSession, StringRequestInfo>(Sock_NewRequestReceived);

        }

        // <summary>
        // Deze void handeld een verbinding van de eindgebruiker. 
        // </summary>
        // <param id="session">Sessie van de socket.</param>
        // <param id="requestInfo">Geen info atm</param>
        private void Sock_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
        {
            session.Send("BK hoi");
        }
    }
}
