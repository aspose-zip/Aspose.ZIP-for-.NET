using System;
using System.IO;
using Aspose.Zip.LZMA;

namespace Aspose.ZIP.Examples.WorkWithLzma
{
    public class DecompressFromLzma
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            using (var archive = new LzmaArchive(dataDir + "archive.lzma"))
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