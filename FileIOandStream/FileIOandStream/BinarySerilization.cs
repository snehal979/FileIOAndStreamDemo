using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOandStream
{
    public class BinarySerilization
    {
        
        public void Serialization(string filepath)
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(filepath, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
           

        }
        public void DeSerialization(string filepath)
        {
            FileStream fileStream = new FileStream(filepath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationSample = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName :{ deserializationSample.ApplicationName}---ApplicationId  {deserializationSample.ApplicationId}");
           
        }
    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialization";
        public int ApplicationId { get; set; } = 10001;
    }
}
