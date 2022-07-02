using System.IO;
using Aspose.Zip.Wim;

namespace Aspose.ZIP.Examples.WorkingWithWim
{
    public class DecompressWimToFolder
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: DecompressWimArchive
            using (FileStream fs = File.OpenRead(dataDir + "corpus.wim"))
            {
                using (WimArchive archive = new WimArchive(fs))
                {
                    archive.Images[0].ExtractToDirectory(dataDir + "DecompressWim_out");
                }
            }
            //ExEnd: DecompressWimArchive
        }
    }
}