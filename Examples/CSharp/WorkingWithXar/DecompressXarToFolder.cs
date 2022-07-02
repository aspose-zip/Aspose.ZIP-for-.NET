using System.IO;
using Aspose.Zip.Xar;

namespace Aspose.ZIP.Examples.WorkingWithXar
{
    public class DecompressXarToFolder
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: DecompressXarArchive
            using (FileStream fs = File.OpenRead(dataDir + "sample.xar"))
            {
                using (XarArchive archive = new XarArchive(fs))
                {
                    archive.ExtractToDirectory(dataDir + "DecompressXar_out");
                }
            }
            //ExEnd: DecompressXarArchive
        }
    }
}