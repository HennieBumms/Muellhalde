using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Beispiel bsp = new Beispiel();

            bsp.Event += EventFunction;
            bsp.MyEvent += MyEventFunction;

            bsp.OnEvent(new EventArgs());
            bsp.OnMyEvent("Beispiel");
        }

        public static void EventFunction(object sender, EventArgs e)
        {
            Console.WriteLine("Event ist eingetreten");
        }

        public static void MyEventFunction(string value)
        {
            Console.WriteLine("Value: " + value);
        }

        class Beispiel
        {
            public event EventHandler Event;
            public delegate void MyEventHandler(string info);

            public MyEventHandler MyEvent;
            public virtual void OnEvent(EventArgs e)
            {
                EventHandler handler = Event;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

            public virtual void OnMyEvent(string value)
            {
                MyEventHandler myHandler = MyEvent;
                myHandler(value);
            }
        }
    }
}
