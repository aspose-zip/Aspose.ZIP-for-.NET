namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Cab;
using Aspose.ZIP.Examples;

public class CancelCabExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new CabLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new CabArchive(dataDir + "archive.cab", loadOptions))
            {
                archive.ExtractToDirectory(dataDir + "cab_out");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled CAB Archive extraction");
            }
        });
    }
}
