using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFolders
{
    public class CompressDirectory
    {
        public static void Run()
        {
            //ExStart: DeCompressDirectory
            string dataDir = RunExamples.GetDataDir_Data();

            using (FileStream zipFile = File.Open(dataDir + "CompressDirectory_out.zip", FileMode.Create))
            {
                using (FileStream zipFile2 = File.Open(dataDir + "CompressDirectory2_out.zip", FileMode.Create))
                {
                    using (Archive archive = new Archive())
                    {
                        DirectoryInfo corpus = new DirectoryInfo(dataDir + "CanterburyCorpus");
                        archive.CreateEntries(corpus);
                        archive.Save(zipFile);
                        archive.Save(zipFile2);
                    }
                }
            }
            //ExEnd: DeCompressDirectory
        }
    }
}
