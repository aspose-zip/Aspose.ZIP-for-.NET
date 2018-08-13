using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class DecompressSingleFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            CompressSingleFile.Run();       //Create a compressed file to work with

            //ExStart: DecompressSingleFile
            using (FileStream fs = File.OpenRead(dataDir + "CompressSingleFile_out.zip"))
            {
                using (Archive archive = new Archive(fs))
                {
                    int percentReady = 0;
                    archive.Entries[0].ExtractionProgressed += (s, e) =>
                    {
                        int percent = (int)((100 * e.ProceededBytes) / ((ArchiveEntry)s).UncompressedSize);
                        if (percent > percentReady)
                        {
                            Console.WriteLine(string.Format("{0}% decompressed", percent));
                            percentReady = percent;
                        }
                    };
                    archive.Entries[0].Extract(dataDir + "alice_extracted_out.txt");
                }
            }
            //ExEnd: DecompressSingleFile
        }
    }
}
