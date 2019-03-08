using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal {
    class Program {
        static void Main(string[] args) {
            Metodos mts = new Metodos();

            Console.WriteLine("¿El semaforo esta en?\n1. Verde\n2. Amarillo\n3. Rojo");
            mts.Lineas();
            int a = int.Parse(Console.ReadLine());
            mts.Lineas();

            switch (a) {
                case 1:
                    mts.Green();
                    break;
                case 2:
                    mts.Yellow();
                    break;
                case 3:
                    mts.Red();
                    break;
            }

            Console.ReadKey();
        }
    }
}
