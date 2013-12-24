using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HybridEmu.Core.Communication
{
    class SocketListener
    {
        /// <summary>
        /// Buffers voor sockets zijn unmanaged in .NET
        /// </summary>
        BufferManager theBufferManager;

        /// <summary>
        /// De socket die luistert naar alle inkomende verbindingen.
        /// </summary>
        Socket listenSocket;

        /// <summary>
        /// Dit gaat niet over het beheren van threads.
        /// </summary>
        Semaphore theMaxConnectionsEnforcer;


        /// <summary>
        /// Instellingen van de socket server.
        /// </summary>
        SocketListenerSettings socketListenerSettings;


        /// <summary>
        /// Constructor van de socket listener.
        /// </summary>
        /// <param name="theSocketListenerSettings">Instellingen voor de socket server</param>
        public SocketListener(SocketListenerSettings theSocketListenerSettings)
        { 
            
        }

    }
}
