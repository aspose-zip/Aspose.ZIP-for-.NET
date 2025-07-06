using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CancelWithToken
{
    using Aspose.Zip.Gzip;

    public class CancelGzipExtractionTask
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: OpenGzArchive
            //Extracts the archive and copies extracted content to file stream.

            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(500); //Cancel soon

            Task t = Task.Run(() =>
            {
                var loadOptions = new GzipLoadOptions() { CancellationToken = cts.Token };
                using (var archive = new GzipArchive(dataDir + "archive.gz", loadOptions))
                {
                    using (var extracted = File.Create(dataDir + "alice29_out.txt"))
                    {
                        archive.Extract(extracted);
                    }
                }
            }, cts.Token);

            t.ContinueWith((Task antecedent) => 
            { 
                if (antecedent.IsCanceled)
                {
                    Console.WriteLine("Successfully cancelled xz Archive extraction");
                }
            });
           
            //ExEnd: OpenGzArchive
        }
    }
}
