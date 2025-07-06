namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Arj;

public class CancelArjExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new ArjLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new ArjArchive(dataDir + "archive.arj", loadOptions))
            {
                archive.ExtractToDirectory(dataDir + "arj_out");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled ARJ Archive extraction");
            }
        });
    }
}