using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using Aspose.Zip;
using System.Collections.ObjectModel;
using Aspose.Zip.Saving;
using System.Text;
using System.Web;
using System.Reflection;
using System.Diagnostics;

namespace Aspose.ZIP.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeZipCompress class to compress or uncompress files
	///</Summary>
	public class AsposeZipCompress : ZIPBase
	{
		private Response response;
		private Response ProcessTask(string fileName, string folderName,   inFileActionDelegate action)
		{
			Aspose.ZIP.Live.Demos.UI.Models.License.SetAsposeZIPLicense();			
			return  Process(this.GetType().Name, fileName, folderName, (new StackTrace()).GetFrame(5).GetMethod().Name, action);
		}
		///<Summary>
		/// CompressFile method to compress file
		///</Summary>
		
		public Response CompressFile(string fileName, string folderName, string zipFileName,  string ispasswordprotected, string password, string encryptionType)
		{
			FileStream zipFile = null;
			bool isZipExist = false;
			ispasswordprotected = ispasswordprotected.ToLower();
			encryptionType = encryptionType.ToLower();
			// Check if zip file already exist or not
			if (zipFileName == "")
			{
				string guid = Guid.NewGuid().ToString();
				zipFileName = guid + "_CompressFiles.zip";
				zipFile = System.IO.File.Open(Config.Configuration.OutputDirectory + zipFileName, FileMode.Create);
			}
			else
			{
				isZipExist = true;				
			}		
		 
			response =  ProcessTask(fileName, folderName,   delegate (string inFilePath)
		   {

			   using (FileStream infile = System.IO.File.Open(inFilePath, FileMode.Open, FileAccess.Read))
			   {
				   Archive archive = null;
				   EncryptionMethod encryptionMethod = EncryptionMethod.AES128;
				   if (encryptionType == "aes192")
				   {
					   encryptionMethod = EncryptionMethod.AES192;
				   }
				   else if (encryptionType == "aes256")
				   {
					   encryptionMethod = EncryptionMethod.AES256;
				   }

				   if ((ispasswordprotected == "true") && (encryptionType.ToLower() == "traditional") && (!isZipExist))
				   {
					   archive = new Archive(new ArchiveEntrySettings(null, new TraditionalEncryptionSettings(password)));
				   }
				   else if ((ispasswordprotected == "true") && (encryptionType.ToLower() != "traditional") && (!isZipExist))
				   {					   
					   archive = new Archive(new ArchiveEntrySettings(null, new AesEcryptionSettings(password, encryptionMethod)));
				   }
				   else if ((!isZipExist) && (ispasswordprotected == "false"))
				   {
					   archive = new Archive(new ArchiveEntrySettings());
				   }
				   else if ((isZipExist) && (ispasswordprotected == "false"))
				   {
					   archive = new Archive(Config.Configuration.OutputDirectory + zipFileName);
				   }
				   else if ((isZipExist) && (ispasswordprotected == "true") && (encryptionType.ToLower() == "traditional"))
				   {
					   archive = new Archive(Config.Configuration.OutputDirectory + zipFileName, null, new ArchiveEntrySettings(null, new TraditionalEncryptionSettings(password)));
				   }
				   else if ((isZipExist) && (ispasswordprotected == "true") && (encryptionType.ToLower() != "traditional"))
				   {
					   archive = new Archive(Config.Configuration.OutputDirectory + zipFileName, null, new ArchiveEntrySettings(null, new AesEcryptionSettings(password, encryptionMethod)));
				   }
				   using (archive)
				   {
					   archive.CreateEntry(fileName, infile);
					   if (isZipExist)
					   {
						   archive.Save(Config.Configuration.OutputDirectory + zipFileName, new ArchiveSaveOptions() { Encoding = Encoding.ASCII, ArchiveComment = "compress" });
					   }
					   else
					   {
						   archive.Save(zipFile, new ArchiveSaveOptions() { Encoding = Encoding.ASCII, ArchiveComment = "compress" });
					   }

				   }

				   infile.Close();
				   infile.Dispose();
				   if (zipFile != null)
				   {
					   zipFile.Close();
					   zipFile.Dispose();
				   }
			   }
		   });
			
			// ZipFile Name as Text to use at frontend
			response.Text = zipFileName;		
			return response;
		}
		///<Summary>
		/// DecompressFile method to decompress file
		///</Summary>
		
		public Response DecompressFile(string fileName, string folderName, string userEmail, string ispasswordprotected, string password, string encryptionType)
		{

			Collection<string> Files = new Collection<string>();
			string archivefileName = "";
			string outFolder = Guid.NewGuid().ToString();
			string outPath = Config.Configuration.OutputDirectory + outFolder;
			if (!Directory.Exists(outPath))
			{
				Directory.CreateDirectory(outPath);
			}
			ispasswordprotected = ispasswordprotected.ToLower();
			encryptionType = encryptionType.ToLower();
			response =  ProcessTask(fileName, folderName,  delegate (string inFilePath)
			{
				Archive archive = null;
				using (FileStream zipFile = System.IO.File.Open(inFilePath, FileMode.Open))
				{
					if ((ispasswordprotected == "true") && (encryptionType.ToLower() == "traditional"))
					{
						archive = new Archive(zipFile, new ArchiveLoadOptions() { DecryptionPassword = password });
					}
					else
					{
						archive = new Archive(zipFile);
					}

					if ((ispasswordprotected == "true") && (encryptionType.ToLower() != "traditional"))
					{
						using (archive)
						{
							foreach (ArchiveEntry aEntry in archive.Entries)
							{
								archivefileName = aEntry.Name;
								Files.Add(archivefileName);
								using (var extracted = System.IO.File.Create(outPath + "\\" + archivefileName))
								{
									using (var decompressed = aEntry.Open(password))
									{
										// Call WriteArchiveEntry method to write archived file
										WriteArchiveEntry(extracted, decompressed);
									}
								}
							}

						}
					}
					else
					{
						using (archive)
						{
							foreach (ArchiveEntry aEntry in archive.Entries)
							{
								archivefileName = aEntry.Name;
								Files.Add(archivefileName);
								using (var extracted = System.IO.File.Create(outPath + "\\" + archivefileName))
								{
									using (var decompressed = aEntry.Open())
									{
										// Call WriteArchiveEntry method to write archived file
										WriteArchiveEntry(extracted, decompressed);
									}
								}
							}

						}
					}
				}
			});
			response.FolderName = outFolder;
			response.Files = Files;
			return response;
		}
		private void WriteArchiveEntry(FileStream  extracted, Stream decompressed)
		{			
			byte[] buffer = new byte[8192];
			int bytesRead;
			while (0 < (bytesRead = decompressed.Read(buffer, 0, buffer.Length)))
			{
				extracted.Write(buffer, 0, bytesRead);
			}				
		}
	}
}


