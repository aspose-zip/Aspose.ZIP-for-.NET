![Nuget](https://img.shields.io/nuget/v/Aspose.Zip) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Zip) ![GitHub](https://img.shields.io/github/license/aspose-zip/Aspose.Zip-for-.NET)

# .NET API for Files Compression & Archiving

[Aspose.ZIP for .NET](https://products.aspose.com/zip/net) class library allows your .NET applications to compress/decompress files and folders without getting into the complexity of coding new compression algorithms or understanding the existing ones. Enable your programs to work with a vast range of features, such as, creating archives, saving archives, archive extraction, encrypting/decrypting archives, compressing single or multiple files as well as directory contents. It also allows you to apply security to your archived and compressed files and folders via password using ZipCrypto or AES (128, 192, 256) encryption or mixed encryption.

<p align="center">
<a title="Download complete Aspose.ZIP for .NET source code" href="https://github.com/aspose-zip/Aspose.Zip-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Demos](Demos)  | Source code for live demos hosted at https://products.aspose.app/zip/family.
[Examples](Examples)  | A collection of .NET examples that help you learn the product features.

# Compress & Extract Files via .NET

- [Compress files and folders]((https://docs.aspose.com/zip/net/compressing-and-decompressing-files/)) into standard ZIP format using Deflate, Bzip2, LZMA or PPMd compression algorithm.
- Extract RAR4 and RAR5 archives, with and without encryption.
- [Apply simple password or `AES128`, `AES192`, `AES256` encryption to archives](https://docs.aspose.com/zip/net/password-protecting-archives/).
- Employ different protection scheme to each file within an archive.
- Append more files to an existing zipped archive.
- Use `Gzip`, `Bzip2`, `Xz`, `Z` and `Lzip` to pack files & folders into a `TAR` or `Cpio` archive.
- Supports `LZMA`, `LZMA2` or `Bzip2`  compression & optional encryption to create `7z` archives.
- [Track progress of compression](https://docs.aspose.com/zip/net/reporting-compression-progress/).
- Create self-extracting compressed archives.

## Compress Files As

**Compression:** Zip, Tar, Cpio, GZip, Bz2, Z, Xz, Lzip, 7z

## Read Archives

**Decompression:** Zip, Rar, Cab, Tar, Cpio, GZip, Bz2, Z, Xz, Lzip

## Platform Independence

Aspose.ZIP for .NET is implemented using Managed C# and can be used with any .NET language like C#, VB.NET, F# and so on. It can be integrated with any kind of .NET application, from ASP.NET web applications to Windows .NET applications. 

## Get Started with Aspose.ZIP for .NET

Are you ready to give Aspose.ZIP for .NET a try? Simply execute `Install-Package Aspose.Zip` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.ZIP for .NET and want to upgrade the version, please execute `Update-Package Aspose.Zip` to get the latest version.

## How to ZIP files in C#

```csharp
using (var archive = new Archive())
{
   archive.CreateEntry("entry_name.dat", "input_file.dat");
   archive.Save("result_archive.zip");
}
```

## How to UnZIP files in C#

```csharp
using (var archive = new Archive("input_archive.zip"))
{
   archive.ExtractToDirectory("outputDirectory");
}
```
 
## How to create 7z Archive with AES Encryption

```csharp
using (var archive = new SevenZipArchive(new SevenZipEntrySettings(null, new SevenZipAESEncryptionSettings("p@s$"))))
{
   archive.CreateEntry("data.bin", new MemoryStream(new byte[] { 0x00, 0xFF }));
   archive.Save("result_archive.7z");
}
```
------------
##### [Demos](https://products.aspose.app/zip/family):
- [Zip-File](https://products.aspose.app/zip/compression)
- [Unzip-File](https://products.aspose.app/zip/extract)
- [Conversion](https://products.aspose.app/zip/conversion)
- [Merger](https://products.aspose.app/zip/merger)
------------
[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/zip/net) | [Docs](https://docs.aspose.com/zip/net/) | [API Reference](https://apireference.aspose.com/zip/net) | [Examples](https://github.com/aspose-zip/Aspose.ZIP-for-.NET) | [Blog](https://blog.aspose.com/category/zip/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/zip) | [Temporary License](https://purchase.aspose.com/temporary-license)
