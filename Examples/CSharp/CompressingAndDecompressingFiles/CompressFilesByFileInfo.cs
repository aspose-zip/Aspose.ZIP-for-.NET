using Aspose.Zip;
using System.IO;
using System.Text;
using Aspose.Zip.Saving;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class CompressFilesByFileInfo
    {
        public static void Run()
        {
            string dataDir  = RunExamples.GetDataDir_Data();

            //ExStart: CompressFilesByFileInfo
            using (FileStream zipFile = File.Open(dataDir + "CompressFilesByFileInfo_out.zip", FileMode.Create))
            {
                FileInfo fi1 = new FileInfo(dataDir + "alice29.txt");
                FileInfo fi2 = new FileInfo(dataDir + "fields.c");

                using (var archive = new Archive())
                {
                    archive.CreateEntry("alice29.txt", fi1);
                    archive.CreateEntry("fields.c", fi2);
                    archive.Save(zipFile, new ArchiveSaveOptions() { Encoding = Encoding.ASCII });
                }
            }
            //ExEnd: CompressFilesByFileInfo
        }
    }
}
