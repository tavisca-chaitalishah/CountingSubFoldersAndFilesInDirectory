using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSubFoldersAndFilesInDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Folder Path : ");
            String path = Console.ReadLine();
            DirectoryManagar directoryManager = new DirectoryManagar();
           Console.WriteLine( directoryManager.DisplayFoldersAndFiles(path));
            Console.WriteLine("Thankyou.\n Please enter any key to Exit the Application...");
            Console.ReadKey();
        }
    }
}
