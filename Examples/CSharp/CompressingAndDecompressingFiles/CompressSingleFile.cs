using Aspose.Zip;
using System.IO;
using Aspose.Zip.Saving;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class CompressSingleFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            //ExStart: CompressSingleFile
            using (FileStream zipFile = File.Open(dataDir + "CompressSingleFile_out.zip", FileMode.Create))
            {
                //File to be added to archive
                using (FileStream source1 = File.Open(dataDir + "alice29.txt", FileMode.Open, FileAccess.Read))
                {
                    using (var archive = new Archive(new ArchiveEntrySettings()))
                    {
                        archive.CreateEntry("alice29.txt", source1);
                        
                        archive.Save(zipFile);
                    }
                }
            }
            //ExEnd: CompressSingleFile
        }
    }
}
