using System;
using System.ComponentModel;
using Aspose.Zip.Bzip2;
using Aspose.Zip.Tar;

namespace Aspose.ZIP.Examples.CompressToTarXX
{
    public class CompressToTarBz2
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: CompressFile
            using (Bzip2Archive bz2 = new Bzip2Archive())
            {
                using (TarArchive archive = new TarArchive())
                {
                    archive.CreateEntry("alice29.txt", dataDir + "alice29.txt");
                    archive.CreateEntry("lcet10.txt", dataDir + "lcet10.txt");
                    
                    bz2.SetSource(archive);
                    bz2.Save(dataDir + "archive.tar.bz2");
                }
                
            }
            //ExEnd: CompressFile
            
        }
    }
}