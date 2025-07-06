namespace Aspose.ZIP.Examples.EventHandling;

using System;
using System.IO;

public class CompressionProgressReport
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();
        using (FileStream source = File.Open(dataDir + "lcet10.txt", FileMode.Open, FileAccess.Read))
        {
            using (var archive = new Zip.Archive(new Zip.Saving.ArchiveEntrySettings(new Zip.Saving.PPMdCompressionSettings())))
            {
                Zip.ArchiveEntry entry = archive.CreateEntry("lcet10.txt", source);
                int percentReady = 0;
                entry.CompressionProgressed += (s, e) =>
                {
                    int percent = (int)((100 * (long)e.ProceededBytes) / source.Length);
                    if (percent > percentReady)
                    {
                        Console.WriteLine($"{percent}% compressed");
                        percentReady = percent;
                    }
                };
                
                archive.Save(dataDir + "reported_out.zip");
                
            }
        }
        
        Console.WriteLine("Successfully Compressed a zip file with progress reporting");
    }

}