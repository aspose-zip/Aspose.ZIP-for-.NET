using Aspose.Zip;
using Aspose.Zip.Saving;
using System.IO;
using System.Text;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class CreateMultivolumeZip
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            // ExStart: CreateMultivolumeZip
            
            using (Archive archive = new Archive())
            {
                // Add files to the archive
                archive.CreateEntry("alice29.txt", new FileInfo(dataDir + "alice29.txt"));
                archive.CreateEntry("lcet10.txt", new FileInfo(dataDir + "lcet10.txt"));
                archive.CreateEntry("sample.txt", new FileInfo(dataDir + "sample.txt"));


                var saveOptions = new SplitArchiveSaveOptions("MultivolumeArchive", 65536)
                {
                    Encoding = Encoding.ASCII
                };

                // Save the archive as a multivolume ZIP using the SaveSplit method.
                archive.SaveSplit(dataDir, saveOptions);
            }
            // ExEnd: CreateMultivolumeZip
        }
    }
}
