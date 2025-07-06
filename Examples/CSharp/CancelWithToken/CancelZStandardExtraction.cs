namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Zstandard;

public class CancelZStandardExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new ZstandardLoadOptions() { CancellationToken = cts.Token };
        using (var archive = new ZstandardArchive(dataDir + "archive.zst", loadOptions))
        {
            try
            {
                archive.Extract(dataDir + "zstandard_out.bin");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled ZStandard Archive extraction");
            }
        }
    }
}