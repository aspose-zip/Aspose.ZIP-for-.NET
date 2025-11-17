using System;
using System.IO;
using Aspose.Zip;
using Aspose.Zip.Saving;   // provides SelfExtractorOptions

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    /// <summary>
    /// Demonstrates composition of a self‑extracting (SFX) archive using
    /// <see cref="ArchiveSaveOptions.SelfExtractorOptions"/>.
    /// The archive is created and saved directly as an executable, without an
    /// intermediate regular ZIP file.
    /// </summary>
    public class CreateSelfExtractingArchive
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            // Path for the self‑extracting executable.
            string sfxPath = Path.Combine(dataDir, "archive_sfx.exe");

            // Configure the self‑extractor options.
            var saveOptions = new ArchiveSaveOptions
            {
                // Default options – extracts to the folder where the EXE runs.
                // Customise properties (Icon, ExtractionPath, etc.) as needed.
                SelfExtractorOptions = new SelfExtractorOptions()
            };

            // Create the archive, add entries, and save it directly as a self‑extracting EXE.
            using (var archive = new Archive())
            {
                archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                archive.Save(sfxPath, saveOptions);
            }
            
        }
    }
}
