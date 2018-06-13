using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW dreier = new BMW();
            Mercedes merc = new Mercedes();
            Auto auto = (Auto)dreier;
            Mini mini = new Mini();
            //Auto anderes = new Auto();
            Console.WriteLine("Farbe dreier: " + dreier.Farbe);
            Console.WriteLine("Farbe auto (dreier): " + auto.Farbe);
            //Console.WriteLine("Farbe auto (anderes): " + anderes.Farbe);
            Console.WriteLine("Farbe Merc: " + merc.Farbe);
            Console.WriteLine("Farbe Merc: " + ((Auto)merc).Farbe);
            Console.WriteLine("Farbe Mini: " + ((IFahrzeug) mini).Farbe);

            IFahrzeug Motorrad = new Motorrad();

            List<IFahrzeug> liste = new List<IFahrzeug>();
            liste.Add(dreier);
            liste.Add(Motorrad);

            dreier.Fahren();
            dreier.Hupen();
        }
    }

    internal class Auto : IFahrzeug
    {
        public virtual string Farbe
        {
            get
            {
                return "grau";
            }
        }

        public virtual void Hupen()
        {
            Console.WriteLine("Hup");
        }

        public virtual void Fahren()
        {
            Console.WriteLine("vorwärts");
        }
    }

    class BMW : Auto
    {
        public sealed override string Farbe
        {
            get
            {
                return "schwarz";
            }
        }

        public override void Hupen()
        {
            Console.WriteLine("Huuuuuuup");
            //base.Hupen();
        }
    }

    class Mini : BMW
    {
        public new string Farbe
        {
            get
            {
                return "gelb";
            }
        }

    }
   

    class Mercedes : Auto
    {
        public new string Farbe
        {
            get
            {
                return "weiss";
            }
        }
    }

    class Motorrad : IFahrzeug
    {
        public virtual string Farbe
        {
            get
            {
                return "rot";
            }
        }

        public virtual void Fahren()
        {
            Console.WriteLine("kurven");
        }

    }

    interface IFahrzeug
    {
        void Fahren();
        string Farbe { get;}
    }

}
