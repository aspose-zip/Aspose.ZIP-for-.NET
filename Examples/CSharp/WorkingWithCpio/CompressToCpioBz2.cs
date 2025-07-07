
namespace Aspose.ZIP.Examples.CompressToTarXX
{
    using Aspose.Zip.Cpio;
    using Aspose.Zip.Bzip2;

    public class CompressToCpioBz2
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (Bzip2Archive bz2 = new Bzip2Archive())
            {
                using (var archive = new CpioArchive())
                {
                    archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                    archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                    
                    bz2.SetSource(archive);
                    bz2.Save(dataDir + "archive.tcpiobz2");
                }
                
            }
            //ExEnd: CompressFile
            
        }
    }
}