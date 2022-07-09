using System;
using Aspose.Zip.Tar;

namespace Aspose.ZIP.Examples.CompressToTarXX
{
    public class CompressToTarLz
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (TarArchive archive = new TarArchive())
            {
                archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                archive.SaveLzipped(dataDir + "archive.tar.lz");
            }
            //ExEnd: CompressFile
            
        }
    }
}