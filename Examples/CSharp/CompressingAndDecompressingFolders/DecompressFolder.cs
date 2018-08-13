using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFolders
{
    public class DecompressFolder
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            CompressDirectory.Run();    //Create a zip file from Directory to be decompressed later int this example

            //ExStart: DecompressFolder
            using (FileStream zipFile = File.Open(dataDir + "CompressDirectory_out.zip", FileMode.Open))
            {
                using (var archive = new Archive(zipFile))
                {
                    archive.ExtractToDirectory(dataDir + "DecompressFolder_out");
                }
            }
            //ExEnd: DecompressFolder
        }
    }
}
