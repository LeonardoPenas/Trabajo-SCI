using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_SCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════╦════════════╦═══════════════╦══════════════════════════════════════════╗                                       ");
            Console.WriteLine("║¥                     ¥ ║            ║               ║¥¥       Sala de reuniones              ¥¥║                                                                        ");
            Console.WriteLine("║    Oficina del jefe    ║ ALMACEN    ║   Oficina 2   ║            (Sensor 4)                    ║                                        ");
            Console.WriteLine("║       (Sensor 1)       ║ PISO 2     ║   (Sensor 3)  ║              ┌──O───O───┐                ║                                   ");
            Console.WriteLine("║        ┌-----┐         ║ (Sensor 2) ║   ┌─O───O─┐   ║             O│          │O               ║                         ");
            Console.WriteLine("║        │     │         ║        ▄▄  ║   └─O───O─┘   ║              └──O───O───┘                ║                        ");
            Console.WriteLine("║        └-O-O-┘         ║        ██  ║               ║¥¥                                      ¥¥║                        ");
            Console.WriteLine("║                        ║        ██  ║   ┌─O───O─┐   ╠══════════════════════       ═╦═══════════╝                    ");
            Console.WriteLine("║                        ║        ██  ║   └─O───O─┘   ║                              ║                           ");
            Console.WriteLine("║                        ║            ║               ║                              ║                    ");
            Console.WriteLine("║                        ║            ║               ║       ════════════════════╦══╩════════════╗                       ");
            Console.WriteLine("║ ¥                    ¥ ║            ║¥             ¥║                           ║¥¥           ¥¥║              ");
            Console.WriteLine("╠═════════      ═════════╬══════      ╩══════         ╝        PASILLO            ║      ┌--┐     ║                            ");
            Console.WriteLine("║¥¥                                        PASILLO            (sensor 8)          │     O│  │O    ║               ");
            Console.WriteLine("║¥¥                                      (sensor 8)                               │      └--┘     ║                            ");
            Console.WriteLine("╚═══════════════╗    ═══════════════════════╦════════════╦════════════════════════╗   Oficina 3   ║                                ");
            Console.WriteLine("                ║                           │ Lava manos │         BAÑOS          ║  (Sensor 5)   ║              ");
            Console.WriteLine("                ║                           │ (sensor 6) │       (sensor 7)       ║               ║              ");
            Console.WriteLine("                ╚═════════════════════════════════════════════════════════════════╩═══════════════╝                            ");     
        }
    }
}
