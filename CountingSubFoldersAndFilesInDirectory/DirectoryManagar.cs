using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSubFoldersAndFilesInDirectory
{
    class DirectoryManagar
    {
        int folder, file;
        public string DisplayFoldersAndFiles(string path)
        {
           
            foreach (String folderFile in Directory.GetDirectories(path))
            {
                folder++;
                foreach (string files in Directory.GetFiles(folderFile))
                {
                    file++;
                }
                DisplayFoldersAndFiles(folderFile);
            }
            string result = "Total folders are : " + folder + "\nTotal files are : " + file;
            return result;
        }
        
    }
}
