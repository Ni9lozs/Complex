using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Komplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.menu();
        }
    }

    class Menu {
        private readonly Complex[] c = new Complex[2];

        public void menu()
        {
            int menu;
            do {
                menuWrite();
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Print();
                        break;
                    case 2:
                        Sum();
                        break;
                    case 3:
                        Sub();
                        break;
                    case 4:
                        Mul();
                        break;
                    case 5:
                        Div();
                        break;
                }
            } while (menu != 0);
        }

        public Complex complexRead(Complex c) {
            bool jo;
            double re, im;
            Console.WriteLine("Adja meg a komplex szám valós részét: ");
            do
            {
               jo = double.TryParse(Console.ReadLine(), out re);
            } while (!jo);

            Console.WriteLine("Adja meg a komplex szám imaginárius részét: ");
            do
            {
                jo = double.TryParse(Console.ReadLine(), out im);
            } while (!jo);
            c = new Complex(re, im);
            return c;
        }

        public void menuWrite() {
            Console.WriteLine("Válassza ki, mit szeretne csinálni.");
            Console.WriteLine("0 - kilépés a programból");
            Console.WriteLine("1 - Komplex szám kiírása");
            Console.WriteLine("2 - Komplex számok összeadása");
            Console.WriteLine("3 - Két komplex szám kivonása");
            Console.WriteLine("4 - Komplex számok szorzata");
            Console.WriteLine("5 - Két komplex szám osztása");
        }

        public void Print() {
            c[0] = complexRead(c[0]);
            Console.WriteLine(c[0].ToString());
        }

        public void Sum() {
            c[0] = complexRead(c[0]);
            c[1] = complexRead(c[1]);
            Console.WriteLine((c[0] + c[1]).ToString());
        }

        public void Sub() {
            Console.WriteLine("kisebbítendő: ");
            c[0] = complexRead(c[0]);
            Console.WriteLine("kivonandó: ");
            c[1] = complexRead(c[1]);
            Console.WriteLine((c[0] - c[1]).ToString());
        }

        public void Mul() {
            c[0] = complexRead(c[0]);
            c[1] = complexRead(c[1]);
            Console.WriteLine((c[0] * c[1]).ToString());
        }
        
        public void Div()
        {
            Console.WriteLine("Osztandó: ");
            c[0] = complexRead(c[0]);
            Console.WriteLine("Osztó: ");
            c[1] = complexRead(c[1]);
            Console.WriteLine((c[0] / c[1]).ToString());
        }

    }
}