using System;
using Aspose.Zip.Tar;

namespace Aspose.ZIP.Examples.CompressToTarXX
{
    /// <summary>
    /// Demonstrates creating a simple <c>.tar.lzma</c> archive.
    /// The sample builds a tar archive and saves it with LZMA compression,
    /// producing a file named <c>archive.tar.lzma</c>.
    /// </summary>
    public class CompressToTarLzma
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            // ExStart: CompressToTarLzma
            using (TarArchive archive = new TarArchive())
            {
                archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                // Save the archive with LZMA compression.
                archive.SaveLZMACompressed(dataDir + "archive.tar.lzma");
            }
            // ExEnd: CompressToTarLzma
        }
    }
}
