using Aspose.Zip.Gzip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithGZip
{
    public class CompressFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (GzipArchive archive = new GzipArchive())
            {
                archive.SetSource(dataDir + "data.bin");
                archive.Save(dataDir + "archive.gz");
            }
            //ExEnd: CompressFile
            Console.WriteLine("Successfully Compressed a File");
        }
    }
}
