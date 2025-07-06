namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip;

public class CancelZipExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new ArchiveLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new Archive(dataDir + "archive.zip", loadOptions))
            {
                archive.ExtractToDirectory(dataDir + "zip_out");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled ZIP Archive extraction");
            }
        });
    }
}
