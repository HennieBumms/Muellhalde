using System;
using System.Collections;
using System.Net;

namespace Josephus {
    public class JosephusSurvivor {
        public static int JosSurvivor(int n, int k) {
            var data = getFilledArrayList(n);
            k -= 1;
            int removeIndex = 0;
            while (data.Count != 1) {
                if (removeIndex + k > data.Count - 1) {
                    int bla = removeIndex + k - data.Count;
                    while (bla > data.Count - 1) {
                        bla -= data.Count;
                    }
                    removeIndex = bla;
                } else {
                    removeIndex += k;
                }

                data.RemoveAt(removeIndex);
            }

            var winner = data[0];

            return (int) winner;
        }

        private static ArrayList getFilledArrayList(int n) {
            ArrayList data = new ArrayList();
            for (int i = 1; i < n + 1; i++) {
                data.Add(i);
            }

            return data;
        }
    }
}