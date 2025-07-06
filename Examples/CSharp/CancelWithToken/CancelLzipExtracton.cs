namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Lzip;

public class CancelLzipExtracton
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new LzipLoadOptions() { CancellationToken = cts.Token };
        using (var archive = new LzipArchive(dataDir + "archive.lz", loadOptions))
        {
            try
            {
                archive.Extract(dataDir + "lzip_out.bin");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled Lzip Archive extraction");
            }
        }
    }
}