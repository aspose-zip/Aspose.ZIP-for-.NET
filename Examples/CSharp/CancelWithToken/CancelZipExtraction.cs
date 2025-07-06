namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip;

public class CancelZipExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: OpenZipArchive
        //Extracts the archive and copies extracted content to directory.

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new ArchiveLoadOptions() { CancellationToken = cts.Token };

        using (var archive = new Archive(dataDir + "archive.zip", loadOptions))
        {
            try
            {
                archive.ExtractToDirectory(dataDir + "zip_out");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled ZIP Archive extraction");
            }
        }

        //ExEnd: OpenZipArchive
    }
}