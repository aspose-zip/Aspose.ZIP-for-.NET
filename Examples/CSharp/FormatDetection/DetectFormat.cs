namespace Aspose.ZIP.Examples.FormatDetection;

using System;
using System.IO;
using Aspose.Zip.ArchiveInfo;

public class DetectFormat
{
    public static void Run()
    {
        string dataDir = RunExamples.GetDataDir_Data();
        
        string[] files = Directory.GetFiles(dataDir, "archive.*");
        foreach (string file in files)
        {
            ArchiveInstanceInfo info = ArchiveInstanceInfo.GetArchiveInstanceInfo(file);
            Console.WriteLine($"File {Path.GetFileName(file)}: detected format {info.FormatInfo.Format.ToString()}, class {info.FormatInfo.Class.FullName}" );
        }
    }
}