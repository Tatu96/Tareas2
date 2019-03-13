using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Operaciones {
        public void Oper() {
            Console.WriteLine("Bienvendio a BAC");
            Console.Write("Nombre: ");
            string x = Console.ReadLine();
            Console.Write("Cuenta: ");
            double y = double.Parse(Console.ReadLine());

            Cliente cln = new Cliente(x, y);

            Console.WriteLine("------------------------------");
            Console.Write("Cantidad de transacciones: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++) {
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Abono\n2.Retiro");
                Console.WriteLine("------------------------------");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");
                
                switch (b) {
                    case 1:
                        Console.Write("A abonar: ");
                        double abn = double.Parse(Console.ReadLine());
                        cln.Depositar(abn);
                        break;
                    case 2:
                        Console.Write("A retirar: ");
                        double rto = double.Parse(Console.ReadLine());
                        cln.Retirar(rto);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("------------------------------");
                Console.WriteLine("Abonos: " + cln.montoAbono);
                Console.WriteLine("Cargos: " + cln.montoCargo);
            }
        }
    }
}
