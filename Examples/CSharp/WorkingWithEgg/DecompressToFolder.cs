namespace Aspose.ZIP.Examples.WorkingWithEgg;

using System.IO;
using Aspose.Zip.Egg;

public class DecompressEggToFolder
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: DecompressEggArchive
        using (FileStream fs = File.OpenRead(dataDir + "archive.egg"))
        {
            using (var archive = new EggArchive(fs))
            {
                archive.ExtractToDirectory(dataDir + "DecompressEgg_out");
            }
        }
        //ExEnd: DecompressEggArchive
    }
}
