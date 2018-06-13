using System;
using System.IO;
using System.Net;

namespace InputOutput {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Ich schreibe einen String");
            String gelesen = Console.ReadLine();
            Console.WriteLine(gelesen);
            char key = (char) Console.Read();
            // liest die nächsten Tastendrücke aus der Eingabeaufforderung aus bis Return gedrückt
            Console.WriteLine(key);

            Console.WriteLine("Ich schreibe einen String");
            var rkey = Console.ReadKey(); // liest den nächsten Tastendruck der Eingabeaufforderung aus
            Console.WriteLine(rkey.Key);

            File.WriteAllText(@"C:\Users\hzabel\Desktop\taext.txt", "Hier schreibe ich Murks rein!");
            // schreiben in Datei. Der vorherige Inhalt wird überschrieben
            var text = File.ReadAllText(@"C:\Users\hzabel\Desktop\taext.txt"); // lesen aus der Datei
            Console.WriteLine(text);

            using (var stream = new StreamWriter(@"C:\Users\hzabel\Desktop\taext.txt", append: true)) {
                stream.Write(" Ich hänge an");
            }
            text = File.ReadAllText(@"C:\Users\hzabel\Desktop\taext.txt");
            Console.WriteLine(text);
            
        }
    }
}