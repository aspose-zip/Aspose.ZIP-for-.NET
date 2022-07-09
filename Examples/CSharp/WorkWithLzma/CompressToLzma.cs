using System;
using Aspose.Zip.LZMA;

namespace Aspose.ZIP.Examples.WorkWithLzma
{
    public class CompressToLzma
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            
            using (LzmaArchive archive = new LzmaArchive())
            {
                archive.SetSource(dataDir + "alice29.txt");
                archive.Save(dataDir + "archive.lzma");
            }
            //ExEnd: CompressFile
            Console.WriteLine("Successfully Compressed a File");
        }
    }
}