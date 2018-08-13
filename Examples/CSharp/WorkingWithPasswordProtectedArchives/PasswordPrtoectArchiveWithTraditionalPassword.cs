using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives
{
    public class PasswordPrtoectArchiveWithTraditionalPassword
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: PasswordPrtoectArchiveWithTraditionalPassword
            using (FileStream zipFile = File.Open(dataDir + "CompressWithTraditionalEncryption_out.zip", FileMode.Create))
            {
                using (FileStream source1 = File.Open(dataDir + "alice29.txt", FileMode.Open, FileAccess.Read))
                {
                    var archive = new Archive(new ArchiveEntrySettings(null, new TraditionalEncryptionSettings("p@s$")));
                    archive.CreateEntry("alice29.txt", source1);
                    archive.Save(zipFile);
                }
            }
            //ExEnd: PasswordPrtoectArchiveWithTraditionalPassword
        }
    }
}
