using System.IO;
using Aspose.Zip.Rar;

namespace Aspose.ZIP.Examples.RarExtraction
{
    public class DecryptRarArchive
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: DecryptRarArchive
            using (FileStream fs = File.OpenRead(dataDir + "encrypted.rar"))
            {
                using (RarArchive archive = new RarArchive(fs, new RarArchiveLoadOptions() { DecryptionPassword = "p@s$" }))
                {
                    archive.ExtractToDirectory(dataDir + "DecompressRar_out");
                }
            }
            //ExEnd: DecryptRarArchive
        }
    }
}