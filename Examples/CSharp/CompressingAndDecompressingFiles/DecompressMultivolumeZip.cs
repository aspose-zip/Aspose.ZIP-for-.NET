using Aspose.Zip;
using System.IO;
using System.Linq;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    /// <summary>
    /// Demonstrates how to extract a multivolume ZIP archive that was created by <see cref="CreateMultivolumeZip"/>.
    /// The example first runs <c>CreateMultivolumeZip.Run()</c> to generate the split archive
    /// (named "MultivolumeArchive.zip" together with its split parts), then extracts all entries
    /// to the output folder.
    /// </summary>
    public class DecompressMultivolumeZip
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            // Ensure the multivolume archive exists – create it if necessary.
            CreateMultivolumeZip.Run();
           
            // Open the multivolume archive. Aspose.Zip automatically detects and opens all split parts.
            // Open the multivolume archive using the appropriate constructor.
            string mainSegment = Path.Combine(dataDir, "MultivolumeArchive.zip");
            string[] segments = Directory.GetFiles(dataDir, "MultivolumeArchive.z*")
                                         .OrderBy(f => f).Where(f => !f.EndsWith(".zip"))
                                         .ToArray();
            using (Archive archive = new Archive(mainSegment, segments))
            {
                // The archive is now opened; proceed to extract entries.

                // Extract each entry to the output folder while preserving the internal folder structure.
                foreach (var entry in archive.Entries)
                {
                    // Combine the output path with the entry's full name.
                    string outPath = Path.Combine(dataDir, entry.Name);

                    // Extract the entry.
                    using (FileStream output = new FileStream(outPath, FileMode.Create))
                    {
                        entry.Extract(output);
                    }
                }
            }
           
        }
    }
}
