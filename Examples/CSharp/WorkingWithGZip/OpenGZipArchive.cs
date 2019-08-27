using Aspose.Zip.Gzip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithGZip
{
    public class OpenGZipArchive
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: OpenGZipArchive
            //Extracts the archive and copies extracted content to file stream.
            using (var archive = new GzipArchive(dataDir + "archive.gz"))
            {
                using (var extracted = File.Create(dataDir + "data.bin"))
                {
                    var unpacked = archive.Open();
                    byte[] b = new byte[8192];
                    int bytesRead;
                    while (0 < (bytesRead = unpacked.Read(b, 0, b.Length)))
                        extracted.Write(b, 0, bytesRead);
                }
            }
            //ExEnd: OpenGZipArchive
            Console.WriteLine("Successfully Opened GZip Archive");
        }
    }
}
