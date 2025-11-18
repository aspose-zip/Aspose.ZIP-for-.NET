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
    using Aspose.ZIP.Examples.EventHandling;
    using Aspose.ZIP.Examples.FormatDetection;

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
            //FlattenZipFile.Run();
            //CreateSelfExtractingArchive.Run();
            //CreateMultivolumeZip.run();
            #endregion

            #region Compressing and Decompressing Folders
            //CompressDirectory.Run();
            //DecompressFolder.Run();
            #endregion

            #region Working with Password Protection of Archives
            //PasswordProtectArchiveWithTraditionalPassword.Run();
            //DecompressTraditionallyPasswordProtectedFile.Run();
            //PasswordProtectWithAES.Run();
            //DecompressAESEncryptedFile.Run();
            //StoreMultipleFilesWithoutCompressionWithPassword.Run();
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
            // CompressCpioFile.Run();
            // CompressToCpioXz.Run();
            // CompressToCpioLz.Run();
            // CompressToCpioZ.Run();
            // CompressToCpioBz2.Run();
            // CompressToCpioGz.Run();
            // CompressToCpioLzma.Run();
            // CompressToCpioZstd.Run();
            #endregion
            
            #region Work with Iso
            //DecompressIsoToFolder.Run();
            #endregion
            
            #region Work with Lha
            //DecompressLhaToFolder.Run();
            #endregion
            
            #region Work with Lha
            //DecompressArjToFolder.Run();
            #endregion

            #region Compress to tar.xx
            //CompressToTarBz2.Run();
            //CompressToTarGz.Run();
            //CompressToTarLz.Run();
            //CompressToTarXz.Run();
            //CompressToTarZ.Run();
            //CompressToTarLzma.Run();
            //CompressToTarZstd.Run();
            #endregion

            #region Work with Lzma archves
            //CompressToLzma.Run();
            //DecompressFromLzma.Run();
            #endregion

            #region Work with Lz4 archves
            //CompressToLz4.Run();
            //DecompressFromLz4.Run();
            #endregion
            
            #region Work With 7z archives
            // CreateSevenZipEntries.Run();
            // CreateSolidSevenZipArchive.Run();
            // CreateSolidEncryptedSevenZipArchive.Run();
            #endregion
            
            #region Cancellation
            // CancelArjExtraction.Run();
            // CancelArjExtractionTask.Run();
            // CancelBzip2Extraction.Run();
            // CancelBzip2ExtractionTask.Run();
            // CancelCabExtraction.Run();
            // CancelCabExtractionTask.Run();
            // CancelGzipExtraction.Run();
            // CancelGzipExtractionTask.Run();
            // CancelIsoExtraction.Run();
            // CancelIsoExtractionTask.Run();
            // CancelLhaExtraction.Run();
            // CancelLhaExtractionTask.Run();
            // CancelLz4Extraction.Run();
            // CancelLz4ExtractionTask.Run();
            // CancelLzipExtracton.Run();
            // CancelRarExtraction.Run();
            // CancelRarExtractionTask.Run();
            // CancelSevenZipExtraction.Run();
            // CancelSevenZipExtractionTask.Run();
            // CancelWimExtraction.Run();
            // CancelWimExtractionTask.Run();
            // CancelXarExtraction.Run();
            // CancelXarExtractionTask.Run();
            // CancelXzExtraction.Run();
            // CancelXzExtractionTask.Run();
            // CancelZipExtraction.Run();
            // CancelZipExtractionTask.Run();
            // CancelZStandardExtraction.Run();
            // CancelZStandardExtractionTask.Run();
            #endregion

            #region Format Detection
            //DetectFormat.Run();
            //ExtractDetecting.Run();
            #endregion
            
            #region Progress reporting
            //CompressionProgressReport.Run();
            //ExtractionProgressReport.Run();
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
