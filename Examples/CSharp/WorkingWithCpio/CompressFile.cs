using System;
using Aspose.Zip.Cpio;

namespace Aspose.ZIP.Examples.WorkingWithCpio
{
    public class CompressCpioFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (CpioArchive archive = new CpioArchive())
            {
                archive.CreateEntries(dataDir);
                archive.Save(dataDir + "archive.cpio");
            }
            //ExEnd: CompressFile
            Console.WriteLine("Successfully Compressed Files");
        }
    }
}