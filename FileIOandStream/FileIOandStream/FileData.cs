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
        public static void FileExist(string filepath)
        {
           
            if (File.Exists(filepath))
            {
                Console.WriteLine("File Exists");
            }
        }
        /// <summary>
        /// ReadAllLine
        /// </summary>
        /// <param name="filepath"></param>
        public static void ReadAllLine(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        /// <summary>
        /// read all txt
        /// </summary>
        /// <param name="filepath"></param>
        public static void ReadAllTxt(string filepath)
        {
            string lines = File.ReadAllText(filepath);
            Console.WriteLine(lines);
           
        }
        /// <summary>
        /// copy file
        /// </summary>
        /// <param name="filepath"></param>
        public static void copy(string filepath)
        {
            string copyPath = "C:\\Users\\hp\\Desktop\\newFolder\\FileIOAndStreamDemo\\FileIOandStream\\FileIOandStream\\ExampleNew.txt";
            File.Copy(filepath, copyPath);
           

        }
        /// <summary>
        /// Delect file
        /// </summary>
        public static void Delect()
        {
            string copyPath = "C:\\Users\\hp\\Desktop\\newFolder\\FileIOAndStreamDemo\\FileIOandStream\\FileIOandStream\\ExampleNew.txt";
            File.Delete(copyPath);


        }
        public void ReadFromStreamReader(string filepath)
        {
            using (StreamReader sr = File.OpenText(filepath))
            {
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
        public void WriteUsingStreamWriter(string filepath)
        {
            using (StreamWriter sr = File.AppendText(filepath))
            {
                sr.WriteLine("How Are you?");
                sr.Close();
                Console.WriteLine(File.ReadAllText(filepath));
            }
        }
    }
}
