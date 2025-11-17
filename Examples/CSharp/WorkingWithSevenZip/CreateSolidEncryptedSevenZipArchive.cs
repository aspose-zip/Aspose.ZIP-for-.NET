using Aspose.Zip;
using Aspose.Zip.Saving;
using Aspose.Zip.SevenZip;
using System;
using System.IO;

namespace Aspose.ZIP.Examples.WorkingWithSevenZip
{
    /// <summary>
    /// Creates a solid 7z archive that is protected with AES‑256 encryption.
    /// The archive is built using <see cref="SevenZipEntrySettings"/> with solid mode enabled.
    /// Setting the <c>Password</c> property activates AES‑256 encryption for the whole archive.
    /// </summary>
    public static class CreateSolidEncryptedSevenZipArchive
    {
        public static void Run()
        {
            // Folder that contains the files to be archived.
            string sourceFolder = RunExamples.GetDataDir_Data();

            // Destination archive path.
            string archivePath = Path.Combine(sourceFolder, "SolidEncryptedArchive.7z");

            // Password for whole‑archive AES‑256 encryption.
            const string archivePassword = "MySecretPassword123!";

            // Configure entry settings: solid mode, LZMA2 compression, and password.
            SevenZipLZMA2CompressionSettings compressionSettings = new SevenZipLZMA2CompressionSettings();
            SevenZipAESEncryptionSettings encryptionSettings = new SevenZipAESEncryptionSettings(archivePassword);
            SevenZipEntrySettings entrySettings = new SevenZipEntrySettings(compressionSettings, encryptionSettings) { Solid = true };

            // Create the archive using the configured entry settings.
            using (SevenZipArchive archive = new SevenZipArchive(entrySettings))
            {
                // Add every file from the source folder (recursive).
                archive.CreateEntries(sourceFolder);

                // Save the archive to disk.
                archive.Save(archivePath);
            }

            Console.WriteLine($"Solid encrypted 7z archive created at: {archivePath}");
        }
    }
}
