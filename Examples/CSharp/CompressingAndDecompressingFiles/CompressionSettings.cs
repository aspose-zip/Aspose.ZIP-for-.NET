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
    public class CompressionSettings
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            UsingBzip2CompressionSettings(dataDir);
            UsingLZMACompressionSettings(dataDir);
            UsingPPMdCompressionSettings(dataDir);
        }

        public static void UsingBzip2CompressionSettings(string dataDir)
        {
            //ExStart: UsingBzip2CompressionSettings
            using (FileStream zipFile = File.Open(dataDir + "Bzip2Compression_out.zip", FileMode.Create))
            {
                using (Archive archive = new Archive(new ArchiveEntrySettings(new Bzip2CompressionSettings())))
                {
                    archive.CreateEntry("sample.txt", dataDir + "sample.txt");
                    archive.Save(zipFile);
                }
            }
            //ExEnd: UsingBzip2CompressionSettings
        }

        public static void UsingLZMACompressionSettings(string dataDir)
        {
            //ExStart: UsingLZMACompressionSettings
            using (FileStream zipFile = File.Open(dataDir + "LZMACompression_out.zip", FileMode.Create))
            {
                using (Archive archive = new Archive(new ArchiveEntrySettings(new LzmaCompressionSettings())))
                {
                    archive.CreateEntry("sample.txt", dataDir + "sample.txt");
                    archive.Save(zipFile);
                }
            }
            //ExEnd: UsingLZMACompressionSettings
        }

        public static void UsingPPMdCompressionSettings(string dataDir)
        {
            //ExStart: UsingPPMdCompressionSettings
            using (FileStream zipFile = File.Open(dataDir + "PPMdCompression_out.zip", FileMode.Create))
            {
                using (Archive archive = new Archive(new ArchiveEntrySettings(new PPMdCompressionSettings())))
                {
                    archive.CreateEntry("sample.txt", dataDir + "sample.txt");
                    archive.Save(zipFile);
                }
            }
            //ExEnd: UsingPPMdCompressionSettings
        }
    }
}
