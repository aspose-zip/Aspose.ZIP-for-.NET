namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.SevenZip;

public class CancelSevenZipExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(500);

        Task t = Task.Run(() =>
        {
            var loadOptions = new SevenZipLoadOptions() { CancellationToken = cts.Token };
            using (var archive = new SevenZipArchive(dataDir + "archive.7z", loadOptions))
            {
                archive.ExtractToDirectory(dataDir + "sevenzip_out");
            }
        }, cts.Token);

        t.ContinueWith((Task antecedent) =>
        {
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled 7z Archive extraction");
            }
        });
    }
}
