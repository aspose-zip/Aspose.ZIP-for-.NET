using System;
using System.IO;
using System.Linq;
using Aspose.Zip.SevenZip;

namespace Aspose.ZIP.Examples.WorkingWithSevenZip
{
    /// <summary>
    /// Demonstrates how to extract a multi‑volume (split) 7‑zip archive that was created by
    /// <see cref="CreateMultivolumeSevenZipArchive"/>.
    /// The sample first runs <c>CreateMultivolumeSevenZipArchive.Run()</c> to generate the split files,
    /// then extracts all entries to the data directory.
    /// </summary>
    public static class DecompressMiltivolumeSevenZip
    {
        public static void Run()
        {
            // Folder that contains the data files (source files and the generated split archive parts)
            string dataDir = RunExamples.GetDataDir_Data();

            // Ensure the multi‑volume archive exists – create it if necessary.
            CreateMultivolumeSevenZipArchive.Run();

            // The split archive is created by <see cref="CreateMultivolumeSevenZipArchive"/>
            // with the base name \"MultivolumeArchive\". The SaveSplit method creates files like:
            //   MultivolumeArchive.7z.001
            //   MultivolumeArchive.7z.002
            //   …
            // Locate all parts in the correct order.
            string[] parts = Directory.GetFiles(dataDir, "MultivolumeArchive.7z.*")
                .OrderBy(f => f)
                .ToArray();
           
            // Open the multi‑volume archive. The constructor that accepts a string[] of part paths
            // automatically assembles the archive for extraction.
            using (SevenZipArchive archive = new SevenZipArchive(parts))
            {
                // Extract all entries to the same data directory.
                archive.ExtractToDirectory(dataDir);
            }
        }
    }
}