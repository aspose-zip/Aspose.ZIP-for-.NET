namespace Aspose.ZIP.Examples.CompressToTarXX
{
    using Aspose.Zip.Tar;

    public class CompressToTarLz4
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (TarArchive archive = new TarArchive())
            {
                archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                archive.SaveLZ4Compressed(dataDir + "archive.tar.lz4");
            }
            //ExEnd: CompressFile
            
        }
    }
}