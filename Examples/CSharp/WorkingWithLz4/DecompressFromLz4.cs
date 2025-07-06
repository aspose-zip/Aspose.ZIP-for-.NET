using System;
using System.IO;
using Aspose.Zip.Lz4;

namespace Aspose.ZIP.Examples.WorkWithLzma
{
    public class DecompressFromLz4
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            using (var archive = new Lz4Archive(dataDir + "archive.lz4"))
            {
                using (var extracted = File.Create(dataDir + "alice29_out.txt"))
                {
                    archive.Extract(extracted);
                }
            }
            
            Console.WriteLine("Successfully Opened Lzma Archive");
        }
    }
}