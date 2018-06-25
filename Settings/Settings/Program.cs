using System;
using System.Runtime.Remoting.Channels;

namespace Settings {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine(Properties.Settings.Default.Farbe);
            Console.WriteLine(Properties.Settings.Default.Schalter);
        }
    }
}