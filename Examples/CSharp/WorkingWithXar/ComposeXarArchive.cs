using System;
using System.IO;
using Aspose.Zip.Xar;

namespace Aspose.ZIP.Examples.WorkingWithXar
{
    public class ComposeXarArchive
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            string xarOutput = Path.Combine(dataDir, "ComposeXar_out.xar");
            string textFilePath = Path.Combine(dataDir, "alice29.txt");
            string htmlFilePath = Path.Combine(dataDir, "cp.html");
            string directoryToPack = Path.Combine(dataDir, "canterburycorpus");

            //ExStart: ComposeXarArchive
            XarCompressionSettings defaultCompression = new XarZlibCompressionSettings();
            using (XarArchive archive = new XarArchive(defaultCompression))
            {
                archive.CreateEntry("docs/alice.txt", textFilePath, openImmediately: false, compressionSettings: defaultCompression);

                XarCompressionSettings storeCompression = new XarStoreCompressionSettings();
                archive.CreateEntry("docs/reference.html", htmlFilePath, openImmediately: false, compressionSettings: storeCompression);
                archive.CreateEntries(directoryToPack, includeRootDirectory: false, compressionSettings: defaultCompression);

                archive.Save(xarOutput);
            }
            //ExEnd: ComposeXarArchive

            Console.WriteLine("XAR archive composed successfully.");
        }
    }
}
