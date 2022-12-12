using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOandStream
{
    public class FileData
    {
        /// <summary>
        /// exitFile
        /// </summary>
        public static void FileExist()
        {
            string filepath = "C:\\Users\\hp\\Desktop\\newFolder\\FileIOAndStreamDemo\\FileIOandStream\\FileIOandStream\\Example.txt";
            if (File.Exists(filepath))
            {
                Console.WriteLine("File Exists");
            }
        }
    }
}
