using Aspose.Zip;
using Aspose.Zip.Saving;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives
{
    public class StoreMutlipleFilesWithoutCompressionWithPassword
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: StoreMutlipleFilesWithoutCompressionWithPassword
            using (FileStream zipFile = File.Open(dataDir + "StoreMutlipleFilesWithoutCompressionWithPassword_out.zip", FileMode.Create))
            {
                using (FileStream source1 = File.Open(dataDir + "alice29.txt", FileMode.Open, FileAccess.Read))
                {
                    using (var archive = new Archive(new ArchiveEntrySettings(new CompressionSettings(CompressionMethod.Store), new AesEcryptionSettings("p@s$", EncryptionMethod.AES256))))
                    {
                        archive.CreateEntry("alice29.txt", source1);
                        archive.Save(zipFile);
                    }
                }
            }
            //ExEnd: StoreMutlipleFilesWithoutCompressionWithPassword
        }
    }
}
