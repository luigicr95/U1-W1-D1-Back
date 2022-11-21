using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dipendente
    {
        private double _stipendio;

        public double Stipendio { 
            get { return _stipendio;}
            set { _stipendio = value; }
        }

        public string BonusNatalizio()  //LA FUNZIONE HA UN VALORE DI RITORNO
        {
            return "Lo stipendio comprensivo di bonus è:" + (_stipendio + 100);
        }

        public void BonusNatalizioProcedura() //LA PROCEDURA RITORNA VOID
        {
            Console.WriteLine("Lo stipendio totale è:" + (_stipendio + 100));
            //Console.WriteLine($"Lo stipendio totale è: {_stipendio+ 100}"); TEMPLATE LITERAL
        }


        public void AumentaStipendio(double aumento) {
            _stipendio += aumento;
        }
    }
}
