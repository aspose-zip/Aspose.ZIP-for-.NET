namespace Aspose.ZIP.Examples.WorkingWithIso;

using System;
using System.IO;
using Aspose.Zip.Iso;

public class DecompressIsoToFolder
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: DecompressIsoArchive
        using (FileStream fs = File.OpenRead(dataDir + "archive.iso"))
        {
            using (var archive = new IsoArchive(fs))
            {
                archive.ExtractToDirectory(dataDir + "DecompressIso_out");
            }
        }
        //ExEnd: DecompressIsoArchive
        
        Console.WriteLine("Successfully Opened Iso Archive");
    }
}