using Aspose.Zip.SevenZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithSevenZip
{
    public class CreateSevenZipEntry
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CreateSevenZipEntry
            using (FileStream sevenZipFile = File.Open("archive.7z", FileMode.Create))
            {
                using (var archive = new SevenZipArchive())
                {
                    archive.CreateEntry("data.bin", "file.dat");
                    archive.Save(sevenZipFile);
                }
            }
            //ExEnd: CreateSevenZipEntry
            Console.WriteLine("Successfully Created a Seven Zip File with AES Encryption Settings");
        }
    }
}
