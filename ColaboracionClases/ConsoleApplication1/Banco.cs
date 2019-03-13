using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Banco {
        static void Main(string[] args) {
            Operaciones opr = new Operaciones();

            opr.Oper();
            Console.ReadKey();
        }
    }
}
