using Aspose.Zip.Cpio;
using System;

namespace Aspose.ZIP.Examples.CompressToTarXX
{
    /// <summary>
    /// Demonstrates creation of a .cpio archive compressed with LZMA.
    /// </summary>
    public class CompressToCpioLzma
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            // ExStart: CompressToCpioLzma
            using (CpioArchive archive = new CpioArchive())
            {
                archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                // Save the archive with LZMA compression (.cpio.lzma)
                archive.SaveLZMACompressed(dataDir + "archive.cpio.lzma");
            }
            // ExEnd: CompressToCpioLzma
        }
    }
}
