using Aspose.Zip;
using Aspose.Zip.Saving;
using Aspose.Zip.SevenZip;
using System;
using System.IO;
using System.Text;

namespace Aspose.ZIP.Examples.WorkingWithSevenZip
{
    /// <summary>
    /// Demonstrates how to create a multi‑volume (split) 7z archive.
    /// </summary>
    public static class CreateMultivolumeSevenZipArchive
    {
        public static void Run()
        {
            // Folder that contains the files to be archived.
            string sourceFolder = RunExamples.GetDataDir_Data();

            // Configure split‑archive save options:
            // * VolumeSize – size of each part in bytes
            var splitOptions = new SplitSevenZipArchiveSaveOptions("MultivolumeArchive", 65536);

            // Create a SevenZipArchive instance. No special entry settings are needed
            // for a basic split archive, so we use the default constructor.
            using (SevenZipArchive archive = new SevenZipArchive())
            {
                // Add each file from the source folder to the archive.
                // This mimics the CreateMultivolumeZip sample which adds three specific files.
                archive.CreateEntry("alice29.txt", new FileInfo(Path.Combine(sourceFolder, "alice29.txt")));
                archive.CreateEntry("lcet10.txt", new FileInfo(Path.Combine(sourceFolder, "lcet10.txt")));
                archive.CreateEntry("sample.txt", new FileInfo(Path.Combine(sourceFolder, "sample.txt")));

                // Save the archive as a multi‑volume 7z file.
                archive.SaveSplit(sourceFolder, splitOptions);
            }

         
        }
    }
}
