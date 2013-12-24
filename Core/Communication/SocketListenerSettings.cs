using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HybridEmu.Core.Communication
{
    class SocketListenerSettings
    {
        /// <summary>
        /// Maximale verbinding(en) voor de socket server.
        /// </summary>
        private Int32 maxConnections;


        /// <summary>
        /// Deze variabel maakt het mogelijk om wat extra SAEA objecten te maken
        /// voor de pool.
        /// </summary>
        private Int32 numberOfSaeaForRecSend;


        /// <summary>
        /// Maximale wachtende verbindingen die de socket kan houden. 
        /// </summary>
        private Int32 backlog;


        /// <summary>
        /// Buffer grootte voor elke opdracht die de socket server maakt.
        /// </summary>
        private Int32 receiveBufferSize;


    }
}
