namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using Aspose.Zip.SevenZip;

public class CancelSevenZipExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500); // Cancel soon
        var loadOptions = new SevenZipLoadOptions() { CancellationToken = cts.Token };

        using (var archive = new SevenZipArchive(dataDir + "archive.7z", loadOptions))
        {
            try
            {
                archive.ExtractToDirectory(dataDir + "sevenzip_out");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Successfully cancelled 7z Archive extraction");
            }
        }
    }
}