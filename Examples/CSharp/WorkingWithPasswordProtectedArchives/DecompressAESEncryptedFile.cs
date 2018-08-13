using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives
{
    public class DecompressAESEncryptedFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: DecompressAESEncryptedFile
            using (FileStream fs = File.OpenRead(dataDir + "PasswordProtectWithAES256_out.zip"))
            {
                using (var extracted = File.Create(dataDir + "alice_aesextracted_out.txt"))
                {
                    using (Archive archive = new Archive(fs))
                    {
                        using (var decompressed = archive.Entries[0].Open("p@s$"))
                        {
                            byte[] b = new byte[8192];
                            int bytesRead;
                            while (0 < (bytesRead = decompressed.Read(b, 0, b.Length)))
                            {
                                extracted.Write(b, 0, bytesRead);
                            }
                        }
                    }
                }
            }
            //ExEnd: DecompressAESEncryptedFile
        }
    }
}
