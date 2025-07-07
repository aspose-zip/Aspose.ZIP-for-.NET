using System;
using Aspose.Zip.Xz;

namespace Aspose.ZIP.Examples.WorkingWithXzArchives
{
    public class CompressXzFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            
            using (XzArchive archive = new XzArchive())
            {
                archive.SetSource(dataDir + "alice29.txt");
                archive.Save(dataDir + "archive.xz");
            }
            //ExEnd: CompressFile
            Console.WriteLine("Successfully Compressed a xz file");
        }
    }
}