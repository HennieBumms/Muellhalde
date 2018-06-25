using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEnumerableBeispiele
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray =  { 1, 2, 3, 4 };
            string[] stringArray = { "Das", "ist", "ein", "Test" };

            Console.WriteLine(string.Format("Trifft auf alle Elemente zu: {0}",
                intArray.All(x => x > 4)));

            Console.WriteLine(string.Format("Trifft auf irgendein Element zu: {0}",
                intArray.Any(x => x == 4)));

            Console.WriteLine(string.Format("Bildet den Mittelwert: {0}",
                stringArray.Average(x => x.Length)));

            foreach(var x in intArray.Select(x => x.ToString()).Concat(stringArray))
            {
                Console.Write(x + " / ");
            }

            Console.WriteLine();

            Console.WriteLine(string.Format("Die Anzahl der Elemente: {0}",
                stringArray.Count()));

            Console.WriteLine(string.Format("Die Anzahl der Elemente, die max 3 Zeichen lang sind: {0}",
                stringArray.Count(x => x.Length <= 3)));

            Console.WriteLine(string.Format("Das erste Element: {0}",
               stringArray.FirstOrDefault()));

            Console.WriteLine(string.Format("Das letzte Element, das max 3 Zeichen lang ist: {0}",
                stringArray.Last(x => x.Length <= 3)));

            Console.WriteLine(string.Format("Das größte Element: {0}",
                intArray.Max()));
            Console.WriteLine(string.Format("Das kleinste Element: {0}",
                intArray.Min()));

            foreach (var x in Enumerable.Range(1, 10))
            {
                Console.Write(x + " / ");
            }

            Console.WriteLine();

            foreach (var x in stringArray.Reverse())
            {
                Console.Write(x + " / ");
            }

            Console.WriteLine();

            foreach (var x in stringArray.Select(x => x.Length))
            {
                Console.Write(x + " / ");
            }

            Console.WriteLine();

            Console.WriteLine(string.Format("Die Summe der Elemente: {0}",
                intArray.Sum()));

            foreach (var x in stringArray.Select(x => x.Length).Distinct())
            {
                Console.Write(x + " / ");
            }

            Console.WriteLine();

            foreach (var x in stringArray.Select(x => x.Length).Where(x => x == 3))
            {
                Console.Write(x + " / ");
            }

            Console.WriteLine();

            var linqQuery = from number in intArray
                            where (number % 2) == 0
                            select number;            
            
            foreach (int element in linqQuery)
            {
                Console.Write(element + " / ");
            }

            Console.WriteLine();
        }
    }
}
