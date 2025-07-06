using System;
using Aspose.Zip.Lz4;

namespace Aspose.ZIP.Examples.WorkWithLzma
{
    

    public class CompressToLz4
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            
            using (Lz4Archive archive = new Lz4Archive())
            {
                archive.SetSource(dataDir + "alice29.txt");
                archive.Save(dataDir + "archive.lz4");
            }
            //ExEnd: CompressFile
            Console.WriteLine("Successfully Compressed a File");
        }
    }
}