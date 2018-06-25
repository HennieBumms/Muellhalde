using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeInListe
{
    public class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            //int counter = 0;
            //foreach (string s in array1)
            //{
            //    foreach (string t in array2)
            //    {
            //        if (t.Contains(s))
            //        {
            //            counter++;
            //            break;
            //        }
            //    }
            //}
            //string[] retArray = new string[counter];
            //counter = 0;
            //foreach (string s in array1)
            //{
            //    foreach (string t in array2)
            //    {
            //        if (t.Contains(s))
            //        {
            //            if (!retArray.Contains(s))
            //            {
            //                retArray[counter] = s;
            //                counter++;
            //            }                       
            //        }
            //    }
            //}
            //return retArray.OrderBy(o => o).ToArray();

            //return array1.Where(s => array2.Any(t => t.Contains(s))).Distinct().OrderBy(o => o).ToArray();

            return (from word in array1
                         from text in array2
                         where text.Contains(word)
                         select word).Distinct().OrderBy(o => o).ToArray();
        }
    }
}
