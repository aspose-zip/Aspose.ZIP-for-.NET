using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.ZIP.Examples.CompressingAndDecompressingFiles
{
    class ModifyingZipFile
    {
        public static void Run()
        {
            //ExStart: ModifyingZipFile
            string dataDir = RunExamples.GetDataDir_Data();
            
            using (Archive outer = new Archive(dataDir + "outer.zip"))
            {
                List<ArchiveEntry> entriesToDelete = new List<ArchiveEntry>();
                List<string> namesToInsert = new List<string>();
                List<MemoryStream> contentToInsert = new List<MemoryStream>();

                foreach (ArchiveEntry entry in outer.Entries)
                {
                    // Find an entry which is an archive itself
                    if (entry.Name.EndsWith(".zip", StringComparison.InvariantCultureIgnoreCase) /* or another condition */ ) 
                    {
                        // Keep reference to the entry in order to remove it from the archive later
                        entriesToDelete.Add(entry); 
                        MemoryStream innerCompressed = new MemoryStream();

                        //This extracts the entry to a memory stream
                        entry.Open().CopyTo(innerCompressed);

                        // We know that content of the entry is an zip archive so we may extract
                        using (Archive inner = new Archive(innerCompressed)) 
                        {
                            // Loop over entries of inner archive
                            foreach (ArchiveEntry ie in inner.Entries) 
                            {
                                // Keep the name of inner entry.
                                namesToInsert.Add(ie.Name); 
                                MemoryStream content = new MemoryStream();
                                ie.Open().CopyTo(content);

                                // Keep the content of inner entry.
                                contentToInsert.Add(content); 
                            }
                        }
                    }
                }

                // Delete all the entries which are archives itself
                foreach (ArchiveEntry e in entriesToDelete)
                {
                    outer.DeleteEntry(e);
                }

                for (int i = 0; i < namesToInsert.Count; i++)
                {
                    // Adds entries which were entries of inner archives
                    outer.CreateEntry(namesToInsert[i], contentToInsert[i]); 
                }

                outer.Save(dataDir + "flatten.zip");
            }
            //ExEnd: ModifyingZipFile
        }
    }
}
