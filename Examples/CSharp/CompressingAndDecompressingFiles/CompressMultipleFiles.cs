using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class CompressMultipleFiles
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            //ExStart: CompressMultipleFiles
            using (FileStream zipFile = File.Open(dataDir + "CompressMultipleFiles_out.zip", FileMode.Create))
            {
                using (FileStream source1 = File.Open(dataDir + "alice29.txt", FileMode.Open, FileAccess.Read))
                {
                    using (FileStream source2 = File.Open(dataDir + "asyoulik.txt", FileMode.Open, FileAccess.Read))
                    {
                        using (var archive = new Archive())
                        {
                            archive.CreateEntry("alice29.txt", source1);
                            archive.CreateEntry("asyoulik.txt", source2);
                            archive.Save(zipFile, new ArchiveSaveOptions() { Encoding = Encoding.ASCII, ArchiveComment = "There are two poems from Canterbury corpus" });
                        }
                    }
                }
            }
            //ExEnd: CompressMultipleFiles
        }
    }
}
