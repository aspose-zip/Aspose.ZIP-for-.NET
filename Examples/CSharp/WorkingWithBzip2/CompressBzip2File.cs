namespace Aspose.ZIP.Examples.WorkingWithBzip2;

using System;
using Aspose.Zip.Bzip2;

public class CompressBzip2File
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        //ExStart: CompressFile
        using (Bzip2Archive archive = new Bzip2Archive())
        {
            archive.SetSource(dataDir + "alice29.txt");
            archive.Save(dataDir + "archive.bz2");
        }
        //ExEnd: CompressFile
        Console.WriteLine("Successfully Compressed a bzip2 file");
    }
}
