using Aspose.Zip;
using Aspose.Zip.Saving;
using Aspose.Zip.SevenZip;
using System;
using System.IO;

namespace Aspose.ZIP.Examples.WorkingWithSevenZip
{
    /// <summary>
    /// Creates a solid 7z archive without any encryption.
    /// The sample uses <see cref="SevenZipEntrySettings"/> to enable solid mode
    /// and to specify the compression method (LZMA2) with the highest compression level.
    /// </summary>
    public static class CreateSolidSevenZipArchive
    {
        public static void Run()
        {
            // Folder that contains the files to be archived.
            string sourceFolder = RunExamples.GetDataDir_Data();

            // Destination archive path.
            string archivePath = Path.Combine(sourceFolder, "SolidArchive.7z");

            // Configure entry settings: solid mode + LZMA2 compression (level 9).
            SevenZipLZMA2CompressionSettings compressionSettings = new SevenZipLZMA2CompressionSettings();
            SevenZipEntrySettings entrySettings = new SevenZipEntrySettings(compressionSettings, null) { Solid = true };

            // Create the archive using the configured entry settings.
            using (SevenZipArchive archive = new SevenZipArchive(entrySettings))
            {
                // Add every file from the source folder (recursive).
                archive.CreateEntries(sourceFolder);

                // Save the archive to disk.
                archive.Save(archivePath);
            }

            Console.WriteLine($"Solid 7z archive created at: {archivePath}");
        }
    }
}
