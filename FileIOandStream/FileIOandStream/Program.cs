namespace FileIOandStream
{
    class Program
    {
        public static void Main(string[] args)
        {
            string filepath = "C:\\Users\\hp\\Desktop\\newFolder\\FileIOAndStreamDemo\\FileIOandStream\\FileIOandStream\\Example.txt";
            Console.WriteLine("1.exitfile 2.readallline 3. readalltxt 4.copy file");
            int num = Convert.ToInt16(Console.ReadLine());
            switch (num)
            {
                case 1:
                    FileData.FileExist(filepath);
                    break;
                case 2:
                    FileData.ReadAllLine(filepath);
                    break;
                case 3:
                    FileData.ReadAllTxt(filepath);
                    break;
                case 4:
                    FileData.copy(filepath);
                    break;
            }
           
           
        }
    }
}