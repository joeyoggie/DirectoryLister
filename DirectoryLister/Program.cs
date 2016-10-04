using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryLister
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the path from the provided CLI argument
            string path = args[0];
            Console.WriteLine("Size of folders in " + path + @"\");
            List<string> folders = Directory.GetDirectories(path).ToList();
            List<double> foldersSizes = new List<double>();
            List<string> entries = new List<string>();
            DirectoryInfo dirInfo;
            double itemSize;
            //StreamWriter outputWriter = new StreamWriter(path + @"\folders.txt");
            for (int i = 0; i < folders.Count; i++)
            {
                dirInfo = new DirectoryInfo(folders[i]);
                itemSize = dirSize(dirInfo) / 1000000000;
                itemSize = Math.Round(itemSize, 4);
                foldersSizes.Add(itemSize);
                entries.Add(folders[i].Remove(0, path.Length + 1) + " (" + foldersSizes[i] + " GB)");
                //outputWriter.WriteLine(entries[i]);
                Console.WriteLine(entries[i]);
            }
            //outputWriter.Dispose();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }

        public static double dirSize(DirectoryInfo mainDirInfo)
        {
            double size = 0;
            //Add file sizes.
            List<FileInfo> filesInfo = mainDirInfo.GetFiles().ToList();
            foreach (FileInfo fileInfo in filesInfo)
            {
                size += fileInfo.Length;
            }
            //Add subdirectory sizes.
            List<DirectoryInfo> dirsInfo = mainDirInfo.GetDirectories().ToList();
            foreach (DirectoryInfo dirInfo in dirsInfo)
            {
                size += dirSize(dirInfo);
            }
            return (size);
        }

    }
}
