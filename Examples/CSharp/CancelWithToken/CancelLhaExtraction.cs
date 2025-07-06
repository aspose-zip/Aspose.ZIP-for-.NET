namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Lha;

public class CancelLhaExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new LhaLoadOptions() { CancellationToken = cts.Token };

        using (var archive = new LhaArchive(dataDir + "archive.lha", loadOptions))
        {
            try
            {
                archive.ExtractToDirectory(dataDir + "lha_out");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled LHA Archive extraction");
            }
        }
    }
}