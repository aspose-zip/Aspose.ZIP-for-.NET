using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFolders
{
    public class ExtractArchiveWithEntriesHavingDifferentPasswords
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: ExtractArchiveWithEntriesHavingDifferentPasswords
            using (FileStream zipFile = File.Open(dataDir + "\\different_password.zip", FileMode.Open))
            {
                using (Archive archive = new Archive(zipFile))
                {
                    archive.Entries[0].Extract(dataDir + "alice29_extracted_pass_out.txt", "first_pass");
                    archive.Entries[1].Extract(dataDir + "asyoulik_extracted_pass_out.txt", "second_pass");
                }
            }
            //ExEnd: ExtractArchiveWithEntriesHavingDifferentPasswords
        }
    }
}
