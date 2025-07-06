namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Cab;

public class CancelCabExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new CabLoadOptions() { CancellationToken = cts.Token };

        using (var archive = new CabArchive(dataDir + "archive.cab", loadOptions))
        {
            try
            {
                archive.ExtractToDirectory(dataDir + "cab_out");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled CAB Archive extraction");
            }
        }
    }
}