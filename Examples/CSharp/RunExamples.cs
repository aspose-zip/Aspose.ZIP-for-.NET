using Aspose.Zip;
using Aspose.ZIP.Examples.CompressingAndDecompressingFiles;
using Aspose.ZIP.Examples.CompressingAndDecompressingFolders;
using Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            ////License Settings
            //License lic = new License();
            //lic.SetLicense(@"Aspose.Total.NET.lic");

            #region Cmopressing and Decompressing Files
            //CompressSingleFile.Run();
            //CompressMultipleFiles.Run();
            //CompressFilesByFileInfo.Run();
            //StoreMultipleFilesWithoutCompression.Run();
            //DecompressSingleFile.Run();
            //DecompressMultipleFiles.Run();
            //DecompressStoredFile.Run();
            //UsingParallelismToCompressFiles.Run();
            
            #endregion

            #region Cmpressing and Decompressing Folders
            //CompressDirectory.Run();
            //DecompressFolder.Run();
            #endregion

            #region Working with Password Protection of Archives
            //PasswordPrtoectArchiveWithTraditionalPassword.Run();
            //DecompressTraditionallyPasswordProtectedFile.Run();
            //PasswordProtectWithAES.Run();
            //DecompressAESEncryptedFile.Run();
            //StoreMutlipleFilesWithoutCompressionWithPassword.Run();
            //DecompressAESEncryptedStoredFile.Run();
            #endregion

            Console.WriteLine("Done with executing selected example (s)");
            Console.ReadKey();
        }

        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return startDirectory != null ? Path.Combine(startDirectory, "Data\\") : null;
        }
    }
}
