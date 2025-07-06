using Aspose.Zip.Xz;
using Aspose.Zip.Xz.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CancelWithToken
{
    public class CancelXzExtractionTask
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: OpenXzArchive
            //Extracts the archive and copies extracted content to file stream.

            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(500); //Cancel soon

            Task t = Task.Run(() =>
            {
                XzLoadOptions loadOptions = new XzLoadOptions() { CancellationToken = cts.Token };
                using (var archive = new XzArchive(dataDir + "archive.xz", loadOptions))
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
           
            //ExEnd: OpenXzArchive
        }
    }
}
