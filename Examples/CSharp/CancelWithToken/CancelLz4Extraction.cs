namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Lz4;

public class CancelLz4Extraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new Lz4LoadOptions() { CancellationToken = cts.Token };
        using (var archive = new Lz4Archive(dataDir + "archive.lz4", loadOptions))
        {
            try
            {
                archive.Extract(dataDir + "lz4_out.bin");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled LZ4 Archive extraction");
            }
        }
    }
}