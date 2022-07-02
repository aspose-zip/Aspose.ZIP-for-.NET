using System.IO;
using Aspose.Zip.Cab;

namespace Aspose.ZIP.Examples.WorkingWithCab
{
    public class DecompressCabToFolder
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: DecompressCabArchive
            using (FileStream fs = File.OpenRead(dataDir + "corpus.cab"))
            {
                using (CabArchive archive = new CabArchive(fs))
                {
                    archive.ExtractToDirectory(dataDir + "DecompressCab_out");
                }
            }
            //ExEnd: DecompressCabArchive
        }
    }
}