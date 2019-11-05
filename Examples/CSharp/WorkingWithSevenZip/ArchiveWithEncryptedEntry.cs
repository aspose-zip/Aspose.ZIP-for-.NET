using Aspose.Zip;
using Aspose.Zip.Saving;
using Aspose.Zip.SevenZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithSevenZip
{
    public class ArchiveWithEncryptedEntry
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: ArchiveWithEncryptedEntry
            using (FileStream sevenZipFile = File.Open("archive.7z", FileMode.Create))
            {
                using (var archive = new SevenZipArchive())
                {
                    archive.CreateEntry("entry1.bin", 
                        new MemoryStream(new byte[] { 0x00, 0xFF }), 
                        new SevenZipEntrySettings(new SevenZipLZMACompressionSettings(), 
                        new SevenZipAESEncryptionSettings("test1")), 
                        new FileInfo("data1.bin"));
                    archive.Save(sevenZipFile);
                }
            }
            //ExEnd: ArchiveWithEncryptedEntry
            Console.WriteLine("Successfully Created a Seven Zip File with AES Encryption Settings");
        }
    }
}
