using System;
using System.IO;
using Aspose.Zip.Z;

namespace Aspose.ZIP.Examples.WorkingWithZArchives
{
    public class DecompressZFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: OpenGZipArchive
            //Extracts the archive and copies extracted content to file stream.
            using (var archive = new ZArchive(dataDir + "archive.z"))
            {
                using (var extracted = File.Create(dataDir + "alice29_out.txt"))
                {
                    archive.Extract(extracted);
                }
            }
            //ExEnd: OpenGZipArchive
            Console.WriteLine("Successfully Opened Z Archive");
        }
    }
}