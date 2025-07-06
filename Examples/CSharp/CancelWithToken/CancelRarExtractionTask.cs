namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Zip.Rar;

public class CancelRarExtractionTask
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();


        //ExStart: DecompressRarArchive

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(300); //Cancel soon

        Task t = Task.Run(() =>
        {
            var loadOptions = new RarArchiveLoadOptions() { CancellationToken = cts.Token };
            using (FileStream fs = File.OpenRead(dataDir + "plrabn12.rar"))
            {
                using (RarArchive archive = new RarArchive(fs, loadOptions))
                {
                    archive.ExtractToDirectory(dataDir + "DecompressRar_out");
                }
            }
        }, cts.Token);
        
        t.ContinueWith((Task antecedent) => 
        { 
            if (antecedent.IsCanceled)
            {
                Console.WriteLine("Successfully cancelled RAR Archive extraction");
            }
        });
        
        //ExEnd: DecompressRarArchive
    }
}