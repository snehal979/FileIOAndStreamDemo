namespace FileIOandStream
{
    class Program
    {
        public static void Main(string[] args)
        {
            string binaryFile = @"C:\Users\hp\Desktop\newFolder\FileIOAndStreamDemo\FileIOandStream\FileIOandStream\BinaryFile.txt";
            string filepath = "C:\\Users\\hp\\Desktop\\newFolder\\FileIOAndStreamDemo\\FileIOandStream\\FileIOandStream\\Example.txt";
            Console.WriteLine("1.exitfile 2.readallline 3. readalltxt 4.copy file 5.Delect file \n 6.Read from Stream reader 7.write file through stream write \n 8.Serialization and 9 .Deserization");
            BinarySerilization binarySerilization = new BinarySerilization();
            int num = Convert.ToInt16(Console.ReadLine());
            FileData file = new FileData();
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
                case 5:
                    FileData.Delect();
                    break;
                case 6:
                   
                    file.ReadFromStreamReader(filepath);
                    break;
                    case 7:

                    file.WriteUsingStreamWriter(filepath);
                    break;
                case 8:
                    binarySerilization.Serialization(binaryFile);
                    break;
                case 9:
                    binarySerilization.DeSerialization(binaryFile);
                    break;
            }
           
           
        }
    }
}