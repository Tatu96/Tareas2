using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Noches {
    class Program {
        static void Main(string[] args) {
            Pedir pd = new Pedir();

            pd.Ejec();

            Console.ReadKey();
        }
    }
}