namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Iso;

public class CancelIsoExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new IsoLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new IsoArchive(dataDir + "archive.iso", loadOptions))
            {
                archive.ExtractToDirectory(dataDir + "iso_out");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled ISO Archive extraction");
            }
        });
    }
}
