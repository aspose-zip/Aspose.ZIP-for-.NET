using System;
using System.IO;
using Aspose.Zip.Lzip;

namespace Aspose.ZIP.Examples.WorkingWithLzArchives
{
    public class DecompressLzFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: OpenGZipArchive
            //Extracts the archive and copies extracted content to file stream.
            using (var archive = new LzipArchive(dataDir + "archive.lz"))
            {
                using (var extracted = File.Create(dataDir + "alice29_out.txt"))
                {
                    archive.Extract(extracted);
                }
            }
            //ExEnd: OpenGZipArchive
            Console.WriteLine("Successfully Opened Lz Archive");
        }
    }
}