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
    public class PasswordProtectWithAES
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart:PasswordProtectWithAES128
            using (FileStream zipFile = File.Open(dataDir + "PasswordProtectWithAES128_out.zip", FileMode.Create))
            {
                using (FileStream source1 = File.Open(dataDir + "alice29.txt", FileMode.Open, FileAccess.Read))
                {
                    using (var archive = new Archive(new ArchiveEntrySettings(null, new AesEcryptionSettings("p@s$", EncryptionMethod.AES128))))
                    {
                        archive.CreateEntry("alice29.txt", source1);
                        archive.Save(zipFile);
                    }
                }
            }
            //ExEnd: PasswordProtectWithAES128

            //ExStart:PasswordProtectWithAES192
            using (FileStream zipFile = File.Open(dataDir + "PasswordProtectWithAES192_out.zip", FileMode.Create))
            {
                using (FileStream source1 = File.Open(dataDir + "alice29.txt", FileMode.Open, FileAccess.Read))
                {
                    using (var archive = new Archive(new ArchiveEntrySettings(null, new AesEcryptionSettings("p@s$", EncryptionMethod.AES192))))
                    {
                        archive.CreateEntry("alice29.txt", source1);
                        archive.Save(zipFile);
                    }
                }
            }
            //ExEnd: PasswordProtectWithAES192

            //ExStart:PasswordProtectWithAES256
            using (FileStream zipFile = File.Open(dataDir + "PasswordProtectWithAES256_out.zip", FileMode.Create))
            {
                using (FileStream source1 = File.Open(dataDir + "alice29.txt", FileMode.Open, FileAccess.Read))
                {
                    using (var archive = new Archive(new ArchiveEntrySettings(null, new AesEcryptionSettings("p@s$", EncryptionMethod.AES256))))
                    {
                        archive.CreateEntry("alice29.txt", source1);
                        archive.Save(zipFile);
                    }
                }
            }
            //ExEnd: PasswordProtectWithAES256
        }
    }
}
