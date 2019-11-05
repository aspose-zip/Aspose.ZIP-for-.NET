using Aspose.Zip.SevenZip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithSevenZip
{
    public class CreateSevenZipEntries
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CreateSevenZipEntries
            using (SevenZipArchive archive = new SevenZipArchive())
            {
                archive.CreateEntries(dataDir);
                archive.Save("SevenZip.7z");
            }
            //ExEnd: CreateSevenZipEntries
            Console.WriteLine("Successfully Created a Seven Zip File");
        }
    }
}
