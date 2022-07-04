using System;
using System.IO;
using Aspose.Zip.Xz;

namespace Aspose.ZIP.Examples.WorkingWithXzArchives
{
    public class DecompressXzFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: OpenGZipArchive
            //Extracts the archive and copies extracted content to file stream.
            using (var archive = new XzArchive(dataDir + "archive.xz"))
            {
                using (var extracted = File.Create(dataDir + "alice29_out.txt"))
                {
                    archive.Extract(extracted);
                }
            }
            //ExEnd: OpenGZipArchive
            Console.WriteLine("Successfully Opened xz Archive");
        }
    }
}