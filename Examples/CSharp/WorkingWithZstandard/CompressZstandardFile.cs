namespace Aspose.ZIP.Examples.WorkingWithZstandard;

using System;
using Aspose.Zip.Zstandard;

public class CompressZStandardFile
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: CompressFile
        using (ZstandardArchive archive = new ZstandardArchive())
        {
            archive.SetSource(dataDir + "alice29.txt");
            archive.Save(dataDir + "archive.zst");
        }
        //ExEnd: CompressFile
        Console.WriteLine("Successfully Compressed a zstandard file");
    }
}
