namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Lz4;

public class CancelLz4ExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new Lz4LoadOptions() { CancellationToken = cts.Token };
            using (var archive = new Lz4Archive(dataDir + "archive.lz4", loadOptions))
            {
                archive.Extract(dataDir + "lz4_out.bin");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled LZ4 Archive extraction");
            }
        });
    }
}
