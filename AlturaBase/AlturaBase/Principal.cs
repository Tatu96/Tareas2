using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area;

namespace AlturaBase {
    class Principal {
        public static void Main(string[] args) {
            Metodos mts = new Metodos();

            mts.Lineas();
            Console.Write("Ingrese altura: ");
            double a = double.Parse(Console.ReadLine());
            mts.setAltrua(a);
            mts.Lineas();

            Console.Write("Ingrese base: ");
            double b = double.Parse(Console.ReadLine());
            mts.setBase(b);
            mts.Lineas();

            Console.WriteLine("Area: " + mts.getArea());
            Console.WriteLine("Perimetro: " + mts.getPerim());
            mts.Lineas();

            Console.ReadKey();

        }
    }
}
