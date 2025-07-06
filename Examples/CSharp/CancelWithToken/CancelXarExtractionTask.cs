namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Xar;

public class CancelXarExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new XarLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new XarArchive(dataDir + "archive.xar", loadOptions))
            {
                archive.ExtractToDirectory(dataDir + "xar_out");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled XAR Archive extraction");
            }
        });
    }
}
