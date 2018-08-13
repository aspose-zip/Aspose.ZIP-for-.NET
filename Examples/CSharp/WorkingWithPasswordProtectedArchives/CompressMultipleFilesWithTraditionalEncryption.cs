using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives
{
    public class CompressMultipleFilesWithTraditionalEncryption
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressMultipleFilesWithTraditionalEncryption
            using (FileStream zipFile = File.Open(".\\CompressMultipleFilesWithTraditionalEncryption_out.zip", FileMode.Create))
            {
                FileInfo source1 = new FileInfo(".\\CanterburyCorpus\\alice29.txt");
                FileInfo source2 = new FileInfo(".\\CanterburyCorpus\\asyoulik.txt");
                FileInfo source3 = new FileInfo(".\\CanterburyCorpus\\fields.c");

                using (var archive = new Archive(new ArchiveEntrySettings(null, new TraditionalEncryptionSettings("p@s$"))))
                {
                    archive.CreateEntry("alice29.txt", source1);
                    archive.CreateEntry("asyoulik.txt", source2);
                    archive.CreateEntry("fields.c", source3);
                    archive.Save(zipFile);
                }
            }
            //ExEnd: CompressMultipleFilesWithTraditionalEncryption
        }
    }
}
