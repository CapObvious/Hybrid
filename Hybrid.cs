
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HybridEmu
{
    class Hybrid
    {
        public static Thread _ThreadListener = new Thread(acceptConnection);

        // <summary>
        // Hier wordt de opdracht gegeven om data die de emulator nodig heeft op te halen en de server op te starten.
        // </summary>
        public static void Boot()
        {
            _ThreadListener.Priority = ThreadPriority.Highest;
            _ThreadListener.Start();

    
            
        }


    }
}
