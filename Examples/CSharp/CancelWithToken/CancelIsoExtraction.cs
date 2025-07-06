namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Iso;

public class CancelIsoExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new IsoLoadOptions() { CancellationToken = cts.Token };

        using (var archive = new IsoArchive(dataDir + "archive.iso", loadOptions))
        {
            try
            {
                archive.ExtractToDirectory(dataDir + "iso_out");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled ISO Archive extraction");
            }
        }
    }
}