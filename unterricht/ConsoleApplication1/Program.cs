using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApplication1 {
    internal class Program {
        public static void Main(string[] args) {
            int[] numbers = {1, 2, 3, 4, 5};
            String[] strings = new String[5];
            int lengthOfNumbers = numbers.Length;
            Console.WriteLine(numbers[0]);

            List<string> list = strings.ToList();
            // umwandeln eines Arrays in eine Liste

            int[,,] theArray = new int[5, 10, 12];
            // Erzeugung eines mehrdimenensionalen Arrays. Kein Komma: eine Dimension, ein Komma: zweidimensional, zwei Kommas: dreidimensional usw.

            int[,] numbers2D = new int[3, 2] {{9, 99}, {3, 33}, {5, 55}};
            // kurze Form: int[,] numbers2D = {{9,99}, {3,33}, {5,55}}

            Console.WriteLine("The array has {0} dimensions.", theArray.Rank);
            // Array.Rank gibt die Dimensionalität des Arrays aus

            foreach (var i in numbers) {
                Console.WriteLine("anzahl {0} {1}", i, "param");
                // Ausgabe ähnlich wie String.format aus Java. In den geschweiften Klammern stehen die Parameter hinter dem Komma, die Zahl gibt den Index des Parameters aus
            }

            Console.WriteLine(String.Format(@"anzahl/ {1}/ {1}\r\n", 2, "param"));
            // String.Format() siehe oben. Das @ verhindert die Maskierung durch / und \. Das \" würde das hintere " vom String maskieren und einen Compilerfehler verursachen.

            try {
                foreach (var i in new int[] {1, 2, 3, 4, 5}) {
                    if (i == 5) {
                        throw new Exception("nicht 5!");
                    }
                }
            } catch (NotImplementedException ex) {
                // wird wegen dedr Vererbungshierarchie nicht gefangen ?!
                Console.WriteLine("Huhbuh");
            } catch (Exception ex) {
                Console.WriteLine("Exception: {0}", ex.Message);
            } finally {
                Console.WriteLine("BUmmbumm");
            }
        }
    }
}