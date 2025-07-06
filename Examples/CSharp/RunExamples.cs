using Aspose.Zip;
using Aspose.ZIP.Examples.CancelWithToken;
using Aspose.ZIP.Examples.CompressingAndDecompressingFiles;
using Aspose.ZIP.Examples.CompressingAndDecompressingFolders;
using Aspose.ZIP.Examples.CompressToTarXX;
using Aspose.ZIP.Examples.RarExtraction;
using Aspose.ZIP.Examples.WorkingWithCab;
using Aspose.ZIP.Examples.WorkingWithCpio;
using Aspose.ZIP.Examples.WorkingWithGZip;
using Aspose.ZIP.Examples.WorkingWithLzArchives;
using Aspose.ZIP.Examples.WorkingWithPasswordProtectedArchives;
using Aspose.ZIP.Examples.WorkingWithXzArchives;
using Aspose.ZIP.Examples.WorkingWithZArchives;
using  Aspose.ZIP.Examples.WorkWithLzma;
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

            #region Compressing and Decompressing Files
            //CompressSingleFile.Run();
            //CompressMultipleFiles.Run();
            //CompressFilesByFileInfo.Run();
            //StoreMultipleFilesWithoutCompression.Run();
            //DecompressSingleFile.Run();
            //DecompressMultipleFiles.Run();
            //DecompressStoredFile.Run();
            //UsingParallelismToCompressFiles.Run();
            //CompressionSettings.Run();
            //ModifyingZipFile.Run();
            #endregion

            #region Compressing and Decompressing Folders
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

            #region WorkingWithGZip
            //OpenGZipArchive.Run();
            //ExtractToMemoryStream.Run();
            //CompressFile.Run();
            //SaveToStream.Run();
            #endregion

            #region Rar extraction
            //DecompressRarEntry.Run();
            //DecompressRarArchive.Run();
            //DecryptRarArchive.Run();
            #endregion

            #region Work with Cab
            //DecompressCabToFolder.Run();
            #endregion

            #region Work with Z archives
            //CompressZFile.Run();
            //DecompressZFile.Run();
            #endregion

            #region Work with Xz archives
            //CompressXzFile.Run();
            //DecompressXzFile.Run();
            #endregion

            #region Work With Lz archives
            //CompressLzFile.Run();
            //DecompressLzFile.Run();
            #endregion

            #region Work with Cpio
            //CompressCpioFile.Run();
            #endregion

            #region Compress to tar.xx
            //CompressToTarBz2.Run();
            //CompressToTarGz.Run();
            //CompressToTarLz.Run();
            //CompressToTarXz.Run();
            //CompressToTarZ.Run();
            #endregion

            #region Work with Lzma archves
            CompressToLzma.Run();
            //DecompressFromLzma.Run();
            #endregion

            #region Work with Lz4 archves
            CompressToLz4.Run();
            //DecompressFromLz4.Run();
            #endregion
            
            #region Cancellation
            //CancelXzExtraction.Run();
            //CancelXzExtractionTask.Run();
            #endregion

            Console.WriteLine("Done with executing selected example (s)");
            Console.ReadKey();
        }

        public static string GetDataDir_Data()
        {
            DirectoryInfo parent = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).Parent;
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
            return startDirectory != null ? Path.Combine(startDirectory, "Data" + Path.DirectorySeparatorChar) : null;
        }
    }
}
