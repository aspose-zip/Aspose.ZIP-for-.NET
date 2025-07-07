namespace Aspose.ZIP.Examples.FormatDetection;

using System;
using System.IO;
using Aspose.Zip;

public class ExtractDetecting
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();

        string[] files = Directory.GetFiles(dataDir, "archive.*");
        foreach (string file in files)
        {
            using (IArchive archive = ArchiveFactory.GetArchive(file))
            {
                archive.ExtractToDirectory(dataDir + $"{archive.Format}_out");
                Console.WriteLine($"File {Path.GetFileName(file)} proceeded successfully.");
            }
        }
    }
}