using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class DecompressMultipleFiles
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            CompressMultipleFiles.Run();    //Create a compressed file with multiple files
            
            //ExStart: DecompressMultipleFiles
            using (FileStream zipFile = File.Open(dataDir + "CompressMultipleFiles_out.zip", FileMode.Open))
            {
                StringBuilder sb = new StringBuilder("Entries are: ");
                int percentReady = 0;
                using (Archive archive = new Archive(zipFile,
                    new ArchiveLoadOptions()
                    {
                        EntryListed = (s, e) => { sb.AppendFormat("{0}, ", e.Entry.Name); },
                        EntryExtractionProgressed = (s, e) =>
                        {
                            int percent = (int)((100 * e.ProceededBytes) / ((ArchiveEntry)s).UncompressedSize);
                            if (percent > percentReady)
                            {
                                Console.WriteLine(string.Format("{0}% compressed", percent)); percentReady = percent;
                            }
                        }
                    }))
                {
                    Console.WriteLine(sb.ToString(0, sb.Length - 2));
                    using (var extracted = File.Create(dataDir + "alice_extracted_out.txt"))
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
                    percentReady = 0;
                    archive.Entries[1].Extract(dataDir + "asyoulik_extracted_out.txt");
                }
            }
            //ExEnd: DecompressMultipleFiles
        }
    }
}
