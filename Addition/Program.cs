using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer prt1 = new Printer();
            prt1.Print("hello");

            ChildPrinter prt2 = new ChildPrinter();
            prt2.Print("beauteful");

            ChildPrinter prt3 = new ChildPrinter();
            Printer prt4 = prt3;
            prt4.Print("world");

            Console.ReadKey();
        }
    }
}
