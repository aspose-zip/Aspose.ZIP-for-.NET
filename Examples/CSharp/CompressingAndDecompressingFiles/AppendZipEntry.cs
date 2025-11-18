using Aspose.Zip;
using System;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    /// <summary>
    /// Demonstrates how to append a new entry to an existing ZIP archive and save the result as a new archive.
    /// </summary>
    class AppendZipEntry
    {
        public static void Run()
        {
            //ExStart: AppendZipEntry
            // Get the data directory where sample files are stored.
            string dataDir = RunExamples.GetDataDir_Data();

            // Path to the existing archive (must exist beforehand).
            string sourceArchivePath = dataDir + "archive.zip";

            // Path to the file that will be added as a new entry.
            // The file "ptt5" already exists in the Data folder.
            string fileToAppend = dataDir + "ptt5";

            // Open the existing archive for modification.
            using (Archive archive = new Archive(sourceArchivePath))
            {
                // Append the new entry with the name "ptt5".
                archive.CreateEntry("ptt5", fileToAppend);

                // Save the modified archive under a new name.
                string resultPath = dataDir + "archive_append.zip";
                archive.Save(resultPath);
            }
            //ExEnd: AppendZipEntry
        }
    }
}
