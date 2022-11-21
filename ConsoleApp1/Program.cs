using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dipendente d1 = new Dipendente();
            d1.Stipendio = 1250.00;
            d1.AumentaStipendio(150);

            Console.WriteLine(d1.Stipendio);

            Console.WriteLine(d1.BonusNatalizio());
            d1.BonusNatalizioProcedura();

            Console.ReadLine();
        }
    }
}
