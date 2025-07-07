namespace Aspose.ZIP.Examples.WorkingWithBzip2;

using System;
using System.IO;
using Aspose.Zip.Bzip2;

public class DecompressBzip2File
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: OpenBzip2Archive
        using (var archive = new Bzip2Archive(dataDir + "archive.bz2"))
        {
            using (var extracted = File.Create(dataDir + "alice29_out.txt"))
            {
                archive.Extract(extracted);
            }
        }
        //ExEnd: OpenBzip2Archive
        Console.WriteLine("Successfully Opened bzip2 Archive");
    }
}
