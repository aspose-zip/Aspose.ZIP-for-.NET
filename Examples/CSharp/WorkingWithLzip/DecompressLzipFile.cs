namespace Aspose.ZIP.Examples.WorkingWithLzip;

using System;
using System.IO;
using Aspose.Zip.Lzip;

public class DecompressLzipFile
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: OpenLzipArchive
        using (var archive = new LzipArchive(dataDir + "archive.lz"))
        {
            using (var extracted = File.Create(dataDir + "alice29_out.txt"))
            {
                archive.Extract(extracted);
            }
        }
        //ExEnd: OpenLzipArchive
        Console.WriteLine("Successfully Opened lzip Archive");
    }
}
