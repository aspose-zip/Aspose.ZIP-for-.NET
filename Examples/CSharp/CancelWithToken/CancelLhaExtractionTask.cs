namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Lha;

public class CancelLhaExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new LhaLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new LhaArchive(dataDir + "archive.lha", loadOptions))
            {
                archive.ExtractToDirectory(dataDir + "lha_out");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled LHA Archive extraction");
            }
        });
    }
}
