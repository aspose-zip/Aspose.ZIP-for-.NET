using System;
using Aspose.Zip.Z;

namespace Aspose.ZIP.Examples.WorkingWithZArchives
{
    public class CompressZFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (ZArchive archive = new ZArchive())
            {
                archive.SetSource(dataDir + "alice29.txt");
                archive.Save(dataDir + "archive.z");
            }
            //ExEnd: CompressFile
            Console.WriteLine("Successfully Compressed a File");
        }
    }
}