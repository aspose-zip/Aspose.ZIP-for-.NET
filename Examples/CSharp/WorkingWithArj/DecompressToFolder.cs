namespace Aspose.ZIP.Examples.WorkingWithArj;

using System.IO;
using Aspose.Zip.Arj;

public class DecompressArjToFolder
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: DecompressArjArchive
        using (FileStream fs = File.OpenRead(dataDir + "archive.arj"))
        {
            using (var archive = new ArjArchive(fs))
            {
                archive.ExtractToDirectory(dataDir + "DecompressArj_out");
            }
        }
        //ExEnd: DecompressArjArchive
    }
}
