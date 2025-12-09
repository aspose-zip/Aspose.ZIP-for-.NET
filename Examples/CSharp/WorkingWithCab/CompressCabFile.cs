using System;
using System.IO;
using Aspose.Zip.Cab;

namespace Aspose.ZIP.Examples.WorkingWithCab
{
    public class CompressCabFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            string cabOutputPath = Path.Combine(dataDir, "ComposeCab_out.cab");
            string singleFilePath = Path.Combine(dataDir, "alice29.txt");
            string htmlFilePath = Path.Combine(dataDir, "cp.html");            

            //ExStart: ComposeCabArchive
            // Default entries use MSZip compression.
            CabEntrySettings defaultSettings = new CabEntrySettings(new CabMsZipCompressionSettings());
            using (CabArchive archive = new CabArchive(defaultSettings))
            {
                archive.CreateEntry("texts/alice.txt", singleFilePath);

                // Store selected files without extra compression.
                CabEntrySettings storedSettings = new CabEntrySettings(new CabStoreCompressionSettings());
                archive.CreateEntry("texts/reference.html", htmlFilePath, storedSettings);              

                archive.Save(cabOutputPath);
            }
            //ExEnd: ComposeCabArchive

            Console.WriteLine("CAB archive composed successfully.");
        }
    }
}
