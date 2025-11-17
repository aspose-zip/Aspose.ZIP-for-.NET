using Aspose.Zip.Cpio;
using System;

namespace Aspose.ZIP.Examples.CompressToTarXX
{
    /// <summary>
    /// Demonstrates creation of a .cpio archive compressed with Zstandard.
    /// </summary>
    public class CompressToCpioZstd
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            // ExStart: CompressToCpioZstd
            using (CpioArchive archive = new CpioArchive())
            {
                archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                // Save the archive with Zstandard compression (.cpio.zstd)
                archive.SaveZstandard(dataDir + "archive.cpio.zstd");
            }
            // ExEnd: CompressToCpioZstd
        }
    }
}
