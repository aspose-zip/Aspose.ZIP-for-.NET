using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives
{
    public class PasswordProtectDirectory
    {
        public static void Run()
        {
            //ExStart: PasswordProtectDirectory
            using (FileStream zipFile = File.Open(".\\all_corpus_encrypted_out.zip", FileMode.Create))
            {
                DirectoryInfo corpus = new DirectoryInfo(".\\CanterburyCorpus");
                using (var archive = new Archive(new ArchiveEntrySettings(null, new TraditionalEncryptionSettings("p@s$"))))
                {
                    archive.CreateEntries(corpus);
                    archive.Save(zipFile);
                    //ExEnd: PasswordProtectDirectory
                }
            }
        }
    }
}
