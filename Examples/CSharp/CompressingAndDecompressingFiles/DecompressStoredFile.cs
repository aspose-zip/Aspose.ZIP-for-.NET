using Aspose.Zip;
using System.IO;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class DecompressStoredFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            StoreMultipleFilesWithoutCompression.Run(); //Create a stored file without compression to be used in decompression

            //ExStart: DecompressStoredFile
            using (FileStream zipFile = File.Open(dataDir + "StoreMultipleFilesWithoutCompression_out.zip", FileMode.Open))
            {
                using (Archive archive = new Archive(zipFile))
                {
                    using (var extracted = File.Create(dataDir + "alice_extracted_store_out.txt"))
                    {
                        using (var decompressed = archive.Entries[0].Open())
                        {
                            byte[] buffer = new byte[8192];
                            int bytesRead;
                            while (0 < (bytesRead = decompressed.Read(buffer, 0, buffer.Length)))
                            {
                                extracted.Write(buffer, 0, bytesRead);
                            }
                            // Read from decompressed stream to extracting file.
                        }
                    }

                    using (var extracted = File.Create(dataDir + "asyoulik_extracted_store_out.txt"))
                    {
                        using (var decompressed = archive.Entries[1].Open())
                        {
                            byte[] buffer = new byte[8192];
                            int bytesRead;
                            while (0 < (bytesRead = decompressed.Read(buffer, 0, buffer.Length)))
                            {
                                extracted.Write(buffer, 0, bytesRead);
                            }
                            // Read from decompressed stream to extracting file.
                        }
                    }
                }
            }
            //ExEnd: DecompressStoredFile
        }
    }
}
