using Aspose.Zip.Gzip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithGZip
{
    public class SaveToStream
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: SaveToStream
            //Writes compressed data to http response stream.
            var ms = new MemoryStream();
            using (var archive = new GzipArchive())
            {
                archive.SetSource(new FileInfo(dataDir + "data.bin"));
                archive.Save(ms);
            }
            //ExEnd: SaveToStream
            Console.WriteLine("Successfully Saved to Stream");
        }
    }
}
