namespace Aspose.ZIP.Examples.EventHandling;

using System;
using Aspose.Zip;

public class ExtractionProgressReport
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        using (var archive = new Archive(dataDir + "archive.zip",
                   new ArchiveLoadOptions()
                   {
                       EntryExtractionProgressed = (s, e) =>
                       {
                           int percent = (int)((100 * e.ProceededBytes) / ((ArchiveEntry)s).UncompressedSize);
                           Console.WriteLine($"{percent}% extracted");
                       }
                   }))
        {
            archive.ExtractToDirectory(dataDir + "ReportingExtracion_out");
        }
     
        Console.WriteLine("Successfully Extracted a zip file with progress reporting");
    }
}