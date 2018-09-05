using Aspose.Zip;
using System.IO;
using System.Text;
using Aspose.Zip.Saving;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    public class UsingParallelismToCompressFiles
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: UsingParallelismToCompressFiles
            using (FileStream zipFile = File.Open(dataDir + "UsingParallelismToCompressFiles_out.zip", FileMode.Create))
            {
                using (FileStream source1 = File.Open(dataDir + "alice29.txt", FileMode.Open, FileAccess.Read))
                {
                    using (FileStream source2 = File.Open(dataDir + "asyoulik.txt", FileMode.Open, FileAccess.Read))
                    {
                        using (var archive = new Archive())
                        {
                            archive.CreateEntry("alice29.txt", source1);
                            archive.CreateEntry("asyoulik.txt", source2);
                            //Define the parallelism criterion
                            var parallelOptions = new ParallelOptions
                            {
                                ParallelCompressInMemory = ParallelCompressionMode.Always
                            };
                            archive.Save(zipFile,
                                new ArchiveSaveOptions()
                                {
                                    ParallelOptions = parallelOptions,
                                    Encoding = Encoding.ASCII,
                                    ArchiveComment = "There are two poems from Canterbury corpus"
                                });
                        }
                    }
                }
            }

            //ExEnd: UsingParallelismToCompressFiles
        }
    }
}