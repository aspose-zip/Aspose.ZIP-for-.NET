using Aspose.Zip;
using System.IO;

namespace Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives
{
    public class DecompressCompressedFolderToDirectory
    {
        public static void Run()
        {
            //ExStart: DecompressCompressedFolderToDirectory
            using (FileStream zipFile = File.Open(".\\all_corpus_encrypted.zip", FileMode.Open))
            {
                new Archive(zipFile, new ArchiveLoadOptions() { DecryptionPassword = "p@s$" }).ExtractToDirectory(".\\all_corpus_decrypted");
            }
            //ExEnd: DecompressCompressedFolderToDirectory
        }
    }
}
