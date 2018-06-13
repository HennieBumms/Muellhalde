using System;
using System.IO;

namespace AlternateCase
{
    public class AlternateCaseWriter : StreamWriter {
        private MemoryStream memoryStream;

        public AlternateCaseWriter(Stream stream) : base(stream) {
            memoryStream = (MemoryStream)stream;
        }

        public void Write(string value) {
            String bla = "";
            foreach (var c in value) {
                if (Char.IsLower(c)) {
                    bla += Char.ToUpper(c);
                } else {
                    bla += Char.ToLower(c);
                }
            }
            base.Write(bla);
        }

    }
}
