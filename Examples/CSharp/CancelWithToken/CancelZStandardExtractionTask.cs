namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Zstandard;

public class CancelZStandardExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new ZstandardLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new ZstandardArchive(dataDir + "archive.zst", loadOptions))
            {
                archive.Extract(dataDir + "zstandard_out.bin");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled ZStandard Archive extraction");
            }
        });
    }
}
