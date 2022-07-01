using System.IO;
using Aspose.Zip.Rar;

namespace Aspose.ZIP.Examples.RarExtraction
{
    public class DecompressRarArchive
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: DecompressRarArchive
            using (FileStream fs = File.OpenRead(dataDir + "plrabn12.rar"))
            {
                using (RarArchive archive = new RarArchive(fs))
                {
                    archive.ExtractToDirectory(dataDir + "DecompressRar_out");
                }
            }
            //ExEnd: DecompressRarArchive
        }
    }
}