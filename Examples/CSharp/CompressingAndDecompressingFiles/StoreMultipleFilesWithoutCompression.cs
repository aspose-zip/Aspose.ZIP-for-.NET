using Aspose.Zip;
using Aspose.Zip.Saving;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class StoreMultipleFilesWithoutCompression
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: StoreMultipleFilesWithoutCompression
            //Creates zip archive without compressing files
            using (FileStream zipFile = File.Open(dataDir + "StoreMultipleFilesWithoutCompression_out.zip", FileMode.Create))
            {
                FileInfo fi1 = new FileInfo(dataDir + "alice29.txt");
                FileInfo fi2 = new FileInfo(dataDir + "lcet10.txt");

                using (Archive archive = new Archive(new ArchiveEntrySettings(new CompressionSettings(CompressionMethod.Store))))
                {
                    archive.CreateEntry("alice29.txt", fi1);
                    archive.CreateEntry("lcet10.txt", fi2);
                    archive.Save(zipFile, new ArchiveSaveOptions() { Encoding = Encoding.ASCII });
                }

            }
            //ExEnd: StoreMultipleFilesWithoutCompression
        }
    }
}
