using System.IO;
using Aspose.Zip.Lzx;

namespace Aspose.ZIP.Examples.WorkingWithLzx
{
    public class DecompressToFolder
    {
        public static void Run()
        {
            // Get the data directory used by the other examples
            string dataDir = RunExamples.GetDataDir_Data();

            // ExStart:DecompressLzxArchive
            // Open the LZX archive file (archive.lzx)
            using (FileStream fs = File.OpenRead(Path.Combine(dataDir, "archive.lzx")))
            {
                // Create the LzxArchive instance
                using (var archive = new LzxArchive(fs))
                {
                    // Extract all entries to a sub‑folder named "DecompressLzx_out"
                    archive.ExtractToDirectory(Path.Combine(dataDir, "DecompressLzx_out"));
                }
            }
            // ExEnd:DecompressLzxArchive
        }
    }
}
