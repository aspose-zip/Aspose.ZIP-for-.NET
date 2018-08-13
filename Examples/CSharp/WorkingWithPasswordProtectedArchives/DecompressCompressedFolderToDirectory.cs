using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives
{
    public class DecompressCompressedFolderToDirectory
    {
        public static void Run()
        {
            //ExStart: DecompressCompressedFolderToDirectory
            using (FileStream zipFile = File.Open(".\\all_corpus_encrypted.zip", FileMode.Open))
            {
                new Archive(zipFile, new ArchiveLoadOptions() { DecryptiptionPassword = "p@s$" }).ExtractToDirectory(".\\all_corpus_decrypted");
            }
            //ExEnd: DecompressCompressedFolderToDirectory
        }
    }
}
