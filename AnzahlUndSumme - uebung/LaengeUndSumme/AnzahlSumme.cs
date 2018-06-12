using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung {
    public static class AnzahlSumme {
        
        public static int[] CountPositivesSumNegatives(IEnumerable<int> input) {
            
            int[] sum = {0, 0};

            foreach (var i in input) {
                if (i > 0) {
                    sum[0]++;
                } else if (i < 0) {
                    sum[1] += i;
                }
            }

            return sum; //return an array with count of positives and sum of negatives
        }
    }
}