using System.IO;
using System.IO.Compression;

namespace Zipstream {
    internal class Program {
        public static void Main(string[] args) {
            using (FileStream fileStream = File.Open(@"C:\Users\hzabel\Desktop\taext.txt", FileMode.Open)) {
                using (FileStream compressedFileStream = File.Create(@"C:\Users\hzabel\Desktop\taext.txt" + ".gz")) {
                    using (GZipStream compressionStream =
                        new GZipStream(compressedFileStream, CompressionMode.Compress)) {
                        fileStream.CopyTo(compressionStream);
                    }
                }
            }
        }
    }
}