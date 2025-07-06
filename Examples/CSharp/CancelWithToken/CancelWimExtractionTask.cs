namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Wim;

public class CancelWimExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new WimLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new WimArchive(dataDir + "archive.wim", loadOptions))
            {
                archive.ExtractToDirectory(dataDir + "wim_out");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled WIM Archive extraction");
            }
        });
    }
}
