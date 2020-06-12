# Aspose.ZIP for .NET

[Aspose.ZIP for .NET](https://products.aspose.com/zip/net) is a flexible documents compression and archive manipulation API for standard zip format. API enables .NET applications to achieve files compression/decompression, archiving files as well as folders and encryption of archives. It provides protection via user-defined passwords and traditional encryption using ZipCrypto or AES encryption such as AES128, 192 and AES256.

This repository contains [Demos](Demos) and [Examples](Examples) projects for Aspose.ZIP for .NET to help you learn and write your own applications.

<p align="center">
<a title="Download complete Aspose.ZIP for .NET source code" href="https://github.com/aspose-zip/Aspose.Zip-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>



Directory | Description
--------- | -----------
[Demos](Demos)  | Aspose.ZIP for .NET Live Demos Source Code
[Examples](Examples)  | A collection of .NET examples that help you learn the product features

# .NET API to Manipulate Zipped Archives

It is a standalone .NET API to create, manipulate, extract & protect archive formats including ZIP, BZIP, BZ2 & TAR. 

[Aspose.ZIP for .NET](https://products.aspose.com/zip/net) class library allows your .NET applications to compress/decompress files and folders without getting into the complexity of coding new compression algorithms or understanding the existing ones. Enable your programs to work with a vast range of features, such as, creating archives, saving archives, archive extraction, encrypting/decrypting archives, compressing single or multiple files as well as directory contents. It also allows you to apply security to your archived and compressed files and folders via password, AES (128, 192, 256) encryption or mixed encryption.mixed encryption.

## Archive Processing Features

- [Compress files](https://docs.aspose.com/display/zipnet/Compressing+and+Decompressing+Files#CompressingandDecompressingFiles-CompressingFiles) and [folders](https://docs.aspose.com/display/zipnet/Compressing+and+Decompressing+Folders#CompressingandDecompressingFolders-CompressingDirectoryContents) into standard ZIP formats.
- Supports Deflate, `Bzip2` & `LZMA` compression algorithms.
- Apply simple password or [`AES128`](https://docs.aspose.com/display/zipnet/Password+Protecting+Archives#PasswordProtectingArchives-EncryptionofFileswithAES128), [`AES192`](https://docs.aspose.com/display/zipnet/Password+Protecting+Archives#PasswordProtectingArchives-EncryptionofFileswithAES192), [`AES256`](https://docs.aspose.com/display/zipnet/Password+Protecting+Archives#PasswordProtectingArchives-EncryptionofFileswithAES256) encryption to archives.
- Employ different protection scheme to each file within an archive.
- Append more files to an existing zipped archive.
- Use `Gzip` or `Bzip2` to pack files & folders into a `TAR` archive.
- Supports `LZMA` or `LZMA2` compression & optional encryption to create `7z` archives.
- Create self-extracting compressed archives.

## Enhancements in Version 20.5

- Support for `RAR4` archive extraction.

For the detailed notes, please visit [Aspose.ZIP for .NET 20.5 Release Notes](https://docs.aspose.com/display/zipnet/Aspose.ZIP+for+.NET+20.5+Release+Notes).

## Compress Files As

**Compression:** ZIP, TAR, GZIP, BZ2

## Read Archives

**Decompression:** ZIP, TAR, GZIP, BZ2

## Platform Independence

Aspose.ZIP for .NET is implemented using Managed C# and can be used with any .NET language like C#, VB.NET, F# and so on. It can be integrated with any kind of .NET application, from ASP.NET web applications to Windows .NET applications. 

## Getting Started with Aspose.ZIP for .NET

Are you ready to give Aspose.ZIP for .NET a try? Simply execute `Install-Package Aspose.Zip` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.ZIP for .NET and want to upgrade the version, please execute `Update-Package Aspose.Zip` to get the latest version.

## How to Run the Examples

- You can either clone the repository using your favorite GitHub client or download the ZIP file from here.
- Extract the contents of the ZIP file to any folder on your computer. All the examples are located in the Examples folder.
- There is a Visual Studio solution file, Aspose.ZIP.Examples.CSharp.sln in the folder.
- The project is created in Visual Studio 2013, but the solution file is compatible with Visual Studio 2010 SP1 and higher.
- Open the solution file in Visual Studio and build the project.
- On the first run, the dependencies will automatically be downloaded via NuGet.
- Data folder at the root folder of Examples contains input files used in code examples. It is mandatory that you download the Data folder along with the examples project.
- Open RunExamples.cs file, all the examples are called from here.
- Uncomment the examples you want to run from within the project.

Please find more details for how to run the examples [here](https://docs.aspose.com/display/zipnet/How+to+Run+the+Examples).

## Compress DAT as ZIP using C# Code

You can execute the following code snippet to see how Aspose.ZIP API works in your environment or check the [GitHub Repository](https://github.com/aspose-zip/Aspose.ZIP-for-.NET) for other common usage scenarios.

```csharp
using (var arch = new Archive())
{
   arch.CreateEntry("filename.dat", dir + "file.dat");
   arch.Save(dir + "result.zip");
}
```

## Create 7z Archive with AES Encryption

Aspose.Zip for .NET allows you to apply password protection and encryption to zipped archives. The following C# code sample demonstrates the creation of a Seven Zip file with AES encryption setting.

```csharp
using (var archive = new SevenZipArchive(new SevenZipEntrySettings(null, new SevenZipAESEncryptionSettings("p@s$"))))
{
   archive.CreateEntry("data.bin", new MemoryStream(new byte[] { 0x00, 0xFF }));
   archive.Save("archive.7z");
}
```

[Product Page](https://products.aspose.com/zip/net) | [Docs](https://docs.aspose.com/display/zipnet/Home) | [Demos](https://products.aspose.app/zip/family) | [API Reference](https://apireference.aspose.com/zip/net) | [Examples](https://github.com/aspose-zip/Aspose.ZIP-for-.NET) | [Blog](https://blog.aspose.com/category/zip/) | [Free Support](https://forum.aspose.com/c/zip) | [Temporary License](https://purchase.aspose.com/temporary-license)
