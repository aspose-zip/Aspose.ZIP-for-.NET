namespace Aspose.ZIP.Examples.CompressToTarXX
{
    using Aspose.Zip.Cpio;

    public class CompressToCpioLz
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (var archive = new CpioArchive())
            {
                archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                archive.SaveLzipped(dataDir + "archive.cpio.lz");
            }
            //ExEnd: CompressFile
            
        }
    }
}