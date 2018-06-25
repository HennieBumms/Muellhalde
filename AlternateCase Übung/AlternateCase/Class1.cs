using System;
using System.IO;

namespace AlternateCase
{
    public class AlternateCaseWriter : StreamWriter {

        public AlternateCaseWriter(Stream stream) : base(stream) {
        }

        public override void Write(string value) {
            String result = "";
            foreach (var c in value) {
                if (Char.IsLower(c)) {
                    result += Char.ToUpper(c);
                } else {
                    result += Char.ToLower(c);
                }
            }
            base.Write(result);
        }

    }
}
