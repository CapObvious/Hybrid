using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridEmu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 30);
            Console.Title = "Hybrid - Booting";

            Console.WriteLine("Hybrid Emulator\nVersion 1.0\n****************************\n");

            // Start de emulator op.
            Hybrid.Boot();
        }


    }
}
