namespace Aspose.ZIP.Examples.CancelWithToken
{
    using System;
    using System.IO;
    using System.Threading;
    using Aspose.Zip.Xz;
    using Aspose.Zip.Xz.Settings;

    public class CancelXzExtraction
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: OpenXzArchive
            //Extracts the archive and copies extracted content to file stream.
            
            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(500); //Cancel soon
            XzLoadOptions loadOptions = new XzLoadOptions() {CancellationToken = cts.Token};
            using (var archive = new XzArchive(dataDir + "archive.xz", loadOptions))
            {
                using (var extracted = File.Create(dataDir + "alice29_out.txt"))
                {
                    try
                    {
                        archive.Extract(extracted);
                    }
                    catch (OperationCanceledException) 
                    {
                        Console.WriteLine("Successfully cancelled xz Archive extraction");
                    }
                }
            }
            
            //ExEnd: OpenXzArchive
        }
    }
}