namespace Aspose.ZIP.Examples.EventHandling;

using System;
using System.IO;
using Aspose.Zip.Saving;
using Aspose.Zip;

public class EntryCompressedSample
{
    public static void Run()
    {
        // Prepare source file
        string dataDir = RunExamples.GetDataDir_Data();
        string sourcePath = Path.Combine(dataDir, "lcet10.txt");

        // Create save options with an EventsBag
        var saveOptions = new ArchiveSaveOptions
        {
            EventsBag = new EventsBag()
        };

        // Attach handler to EntryCompressed event
        saveOptions.EventsBag.EntryCompressed += (sender, args) =>
        {
            // args is CancelEntryEventArgs – it provides information about the entry being written.
            // Display the entry name.
            Console.WriteLine($"Entry '{args.Entry.Name}' compressed.");
        };

        // Create archive and add the entry
        using (Archive archive = new Zip.Archive())
        {
            // Both entries are created while their source streams remain open,
            // ensuring the EntryCompressed event fires for each entry during Save.
            using (FileStream source1 = File.OpenRead(sourcePath))
            {
                archive.CreateEntry("lcet10.txt", source1);

                string secondPath = Path.Combine(dataDir, "alice29.txt");
                using (FileStream source2 = File.OpenRead(secondPath))
                {
                    archive.CreateEntry("alice29.txt", source2);


                    // Save the archive with the configured save options
                    string outPath = Path.Combine(dataDir, "entry_compressed_sample.zip");
                    archive.Save(outPath, saveOptions);
                }
            }
        }
    }
}
