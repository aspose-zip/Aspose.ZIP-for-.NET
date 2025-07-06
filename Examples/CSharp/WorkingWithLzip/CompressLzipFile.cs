namespace Aspose.ZIP.Examples.WorkingWithLzip;

using System;
using Aspose.Zip.Lzip;

public class CompressLzipFile
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: CompressFile
        using (LzipArchive archive = new LzipArchive())
        {
            archive.SetSource(dataDir + "alice29.txt");
            archive.Save(dataDir + "archive.lz");
        }
        //ExEnd: CompressFile
        Console.WriteLine("Successfully Compressed a lzip file");
    }
}
