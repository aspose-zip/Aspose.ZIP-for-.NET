namespace Aspose.ZIP.Examples.CancelWithToken;

using System;
using System.IO;
using System.Threading;
using Aspose.Zip.Rar;

public class CancelRarExtraction
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();


        //ExStart: DecompressRarArchive

        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(300); //Cancel soon
        var loadOptions = new RarArchiveLoadOptions() { CancellationToken = cts.Token };
        using (FileStream fs = File.OpenRead(dataDir + "plrabn12.rar"))
        {
            using (RarArchive archive = new RarArchive(fs, loadOptions))
            {
                try
                {
                    archive.ExtractToDirectory(dataDir + "DecompressRar_out");
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Successfully cancelled RAR Archive extraction");
                }
            }
        }
        //ExEnd: DecompressRarArchive
    }
}