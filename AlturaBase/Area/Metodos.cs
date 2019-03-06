using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area {
    public class Metodos {
        private double Altura, Base, Perim, Area;

        public void setAltrua(double a) {
            Altura = a;
        }

        public void setBase(double b) {
            Base = b;
        }

        public double getArea() {
            Area = Base * Altura;
            return Area;
        }

        public double getPerim() {
            Perim = (2 * Altura) + (2 * Base);
            return Perim;
        }

        public void Lineas() {
            Console.WriteLine("-------------------------");
        }
    }
}
