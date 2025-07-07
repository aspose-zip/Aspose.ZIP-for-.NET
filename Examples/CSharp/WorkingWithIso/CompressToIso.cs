namespace Aspose.ZIP.Examples.WorkingWithIso;

using System;
using Aspose.Zip.Iso;

public class CompressToIso
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();
        
        //ExStart: СompressIsoArchive
        using(IsoArchive isoArchive = new IsoArchive())
        {
            isoArchive.CreateEntry("alice.txt", dataDir + "alice29.txt");
            isoArchive.Save(dataDir +"archive_out.iso");
        }
        //ExEnd: СompressIsoArchive
        
        Console.WriteLine("Successfully Compressed Iso File");
    }
}