using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Cliente {
        public string nombre;
        public double monto, montoAbono, montoCargo;


        public Cliente(string x, double y) {
            nombre = x;
            monto = y;
        }

        public void Depositar(double a) {
            monto = monto + a;
            montoAbono = montoAbono + a;
            Console.WriteLine("A depositado: $" + a + "\nSu nuevo saldo es: " + monto);
        }

        public void Retirar(double b) {
            monto = monto - b;
            montoCargo = montoCargo + b;
            Console.WriteLine("A retirado: $" + b + "\nSu nuevo saldo es: " + monto);
        }
    }
}
