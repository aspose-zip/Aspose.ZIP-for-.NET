using System;
using Aspose.Zip.Lzip;

namespace Aspose.ZIP.Examples.WorkingWithLzArchives
{
    public class CompressLzFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (LzipArchive archive = new LzipArchive())
            {
                archive.SetSource(dataDir + "alice29.txt");
                archive.Save(dataDir + "archive.lz");
            }
            //ExEnd: CompressFile
            Console.WriteLine("Successfully Compressed a File");
        }
    }
}