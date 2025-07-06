using System;
using Aspose.Zip.Saving;
using Aspose.Zip.SevenZip;

namespace Aspose.ZIP.Examples.WorkingWithSevenZip
{
    public class SevenZipWithVariousCompressionMethods
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: SevenZipWithVariousCompressionMethods
            
            //LZMA2
            using (SevenZipArchive archive = new SevenZipArchive(new SevenZipEntrySettings(new SevenZipLZMA2CompressionSettings())))
            {
                archive.CreateEntries(dataDir);
                archive.Save("SevenZip_lzma2.7z");
            }
            
            //BZip2
            using (SevenZipArchive archive = new SevenZipArchive(new SevenZipEntrySettings(new SevenZipBZip2CompressionSettings())))
            {
                archive.CreateEntries(dataDir);
                archive.Save("SevenZip_bzip2.7z");
            }
            
            //PPMd
            using (SevenZipArchive archive = new SevenZipArchive(new SevenZipEntrySettings(new SevenZipPPMdCompressionSettings())))
            {
                archive.CreateEntries(dataDir);
                archive.Save("SevenZip_ppmd.7z");
            }
            
            //Store, no compression
            using (SevenZipArchive archive = new SevenZipArchive(new SevenZipEntrySettings(new SevenZipStoreCompressionSettings())))
            {
                archive.CreateEntries(dataDir);
                archive.Save("SevenZip_store.7z");
            }
            
            //ExEnd: SevenZipWithVariousCompressionMethods
            Console.WriteLine("Successfully Created a Seven Zip Files");
        }
    }
}