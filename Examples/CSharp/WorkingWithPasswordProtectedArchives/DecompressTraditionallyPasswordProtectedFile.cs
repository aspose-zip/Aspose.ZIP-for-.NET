using Aspose.Zip;
using System.IO;

namespace Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives
{
    public class DecompressTraditionallyPasswordProtectedFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            PasswordPrtoectArchiveWithTraditionalPassword.Run();    //run password protection a file example to use it later
            //ExStart: DecompressTraditionallyPasswordProtectedFile
            using (FileStream fs = File.OpenRead(dataDir + "CompressWithTraditionalEncryption_out.zip"))
            {
                using (var extracted = File.Create(dataDir + "alice_extracted_out.txt"))
                {
                    using (Archive archive = new Archive(fs, new ArchiveLoadOptions() { DecryptionPassword = "p@s$" }))
                    {
                        using (var decompressed = archive.Entries[0].Open())
                        {
                            byte[] b = new byte[8192];
                            int bytesRead;
                            while (0 < (bytesRead = decompressed.Read(b, 0, b.Length)))
                            {
                                extracted.Write(b, 0, bytesRead);
                            }
                        }
                    }
                }
            }
            //ExEnd: DecompressTraditionallyPasswordProtectedFile
        }
    }
}
