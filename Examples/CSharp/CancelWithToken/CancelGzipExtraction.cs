namespace Aspose.ZIP.Examples.CancelWithToken
{
    using System;
    using System.IO;
    using System.Threading;
    using Aspose.Zip.Gzip;

    public class CancelGzipExtraction
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: OpenGzArchive
            //Extracts the archive and copies extracted content to file stream.
            
            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(500); //Cancel soon
            var loadOptions = new GzipLoadOptions() {CancellationToken = cts.Token};
            using (var archive = new GzipArchive(dataDir + "archive.gz", loadOptions))
            {
                using (var extracted = File.Create(dataDir + "alice29_out.txt"))
                {
                    try
                    {
                        archive.Extract(extracted);
                    }
                    catch (OperationCanceledException) 
                    {
                        Console.WriteLine("Successfully cancelled gzip Archive extraction");
                    }
                }
            }
            
            //ExEnd: OpenGzArchive
        }
    }
}