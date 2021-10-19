using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FileIOOperationDemo
{
    internal class BinarySerialization
    {
        public BinarySerialization()
        {
            Demo sample = new Demo();
            FileStream filestream = new FileStream(@"C:\Users\gokul\source\repos\FileIOOperation\SerializeExample.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(filestream, sample);
        }

        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"C:\Users\gokul\source\repos\FileIOOperation\SerializeExample.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            Demo deserailzeSampleDemo = (Demo)formatter.Deserialize(fileStream);

            Console.WriteLine($"ApplicationName {deserailzeSampleDemo.AppilcationName} --- AppicationId {deserailzeSampleDemo.AppilcationId}");
        }


    }
}
