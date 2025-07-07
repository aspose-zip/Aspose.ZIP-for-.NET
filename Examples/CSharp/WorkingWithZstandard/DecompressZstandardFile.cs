namespace Aspose.ZIP.Examples.WorkingWithZstandard;

using System;
using System.IO;
using Aspose.Zip.Zstandard;

public class DecompressZStandardFile
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: OpenZStandardArchive
        using (var archive = new ZstandardArchive(dataDir + "archive.zst"))
        {
            using (var extracted = File.Create(dataDir + "alice29_out.txt"))
            {
                archive.Extract(extracted);
            }
        }
        //ExEnd: OpenZStandardArchive
        Console.WriteLine("Successfully Opened zstandard Archive");
    }
}
