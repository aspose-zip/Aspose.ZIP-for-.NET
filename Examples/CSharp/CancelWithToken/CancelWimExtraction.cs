namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Wim;

public class CancelWimExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: OpenWimArchive
        //Extracts the WIM archive and copies extracted content to directory.

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new WimLoadOptions() { CancellationToken = cts.Token };

        using (var archive = new WimArchive(dataDir + "archive.wim", loadOptions))
        {
            try
            {
                archive.ExtractToDirectory(dataDir + "wim_out");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled WIM Archive extraction");
            }
        }


        //ExEnd: OpenWimArchive
    }

}