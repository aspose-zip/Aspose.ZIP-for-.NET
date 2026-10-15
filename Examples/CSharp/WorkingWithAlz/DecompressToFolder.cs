namespace Aspose.ZIP.Examples.WorkingWithAlz;

using System.IO;
using Aspose.Zip.Alz;

public class DecompressAlzToFolder
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: DecompressAlzArchive
        using (FileStream fs = File.OpenRead(dataDir + "archive.alz"))
        {
            using (var archive = new AlzArchive(fs))
            {
                archive.ExtractToDirectory(dataDir + "DecompressAlz_out");
            }
        }
        //ExEnd: DecompressAlzArchive
    }
}
