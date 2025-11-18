using Aspose.Zip;
using System;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    class DeleteZipEntry
    {
        public static void Run()
        {
            //ExStart: DeleteZipEntry
            string dataDir = RunExamples.GetDataDir_Data();

            CompressMultipleFiles.Run();
            
            // Path to the source archive created by CompressMultipleFiles sample
            string sourceArchivePath = dataDir + "CompressMultipleFiles_out.zip";

            using (Archive archive = new Archive(sourceArchivePath))
            {
                // Ensure there is at least one entry to delete
                if (archive.Entries.Count > 0)
                {
                    // Delete the first entry (index 0)
                    ArchiveEntry firstEntry = archive.Entries[0];
                    archive.DeleteEntry(firstEntry);
                }

                // Save the modified archive with the remaining entries
                string resultPath = dataDir + "rest_entries.zip";
                archive.Save(resultPath);
            }
            //ExEnd: DeleteZipEntry
        }
    }
}
