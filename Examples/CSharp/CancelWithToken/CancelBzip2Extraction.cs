namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Bzip2;

public class CancelBzip2Extraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new Bzip2LoadOptions() { CancellationToken = cts.Token };
        using (var archive = new Bzip2Archive(dataDir + "archive.bz2", loadOptions))
        {
            try
            {
                archive.Extract(dataDir + "bzip2_out.bin");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled Bzip2 Archive extraction");
            }
        }
    }
}