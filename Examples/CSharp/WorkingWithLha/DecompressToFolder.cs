namespace Aspose.ZIP.Examples.WorkingWithLha;

using System.IO;
using Aspose.Zip.Lha;

public class DecompressLhaToFolder
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: DecompressLhaArchive
        using (FileStream fs = File.OpenRead(dataDir + "archive.lha"))
        {
            using (var archive = new LhaArchive(fs))
            {
                archive.ExtractToDirectory(dataDir + "DecompressLha_out");
            }
        }
        //ExEnd: DecompressLhaArchive
    }
}
