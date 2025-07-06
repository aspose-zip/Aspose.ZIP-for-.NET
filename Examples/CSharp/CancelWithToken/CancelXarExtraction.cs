namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.Xar;

public class CancelXarExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new XarLoadOptions() { CancellationToken = cts.Token };

        using (var archive = new XarArchive(dataDir + "archive.xar", loadOptions))
        {
            try
            {
                archive.ExtractToDirectory(dataDir + "xar_out");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled XAR Archive extraction");
            }
        }
    }
}