namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Arj;

public class CancelArjExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new ArjLoadOptions() { CancellationToken = cts.Token };

        using (var archive = new ArjArchive(dataDir + "archive.arj", loadOptions))
        {
            try
            {
                archive.ExtractToDirectory(dataDir + "arj_out");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled ARJ Archive extraction");
            }
        }
    }
}