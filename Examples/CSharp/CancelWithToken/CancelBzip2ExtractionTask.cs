namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Bzip2;

public class CancelBzip2ExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new Bzip2LoadOptions() { CancellationToken = cts.Token };
            using (var archive = new Bzip2Archive(dataDir + "archive.bz2", loadOptions))
            {
                archive.Extract(dataDir + "bzip2_out.bin");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled Bzip2 Archive extraction");
            }
        });
    }
}