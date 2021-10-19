using System;
using System.IO;

namespace FileIOOperationDemo
{
       internal class StreamReaderDemo
    {
        public StreamReaderDemo()
        {
            string Path = @"C:\Users\gokul\source\repos\FileIOOperation/Example1.txt";
            using (StreamReader sr = File.OpenText(Path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine();
                }
            }
        }

        public void WriteUsingStreamWriter()
        {
            string Path = @"C:\Users\gokul\source\repos\FileIOOperation/Example1.xt";
            using (StreamWriter sr = File.AppendText(Path))
            {
                sr.WriteLine("Hello added text using STREAM writer");
                sr.Close();

                Console.WriteLine(File.ReadAllText(Path));
            }
        }
    }
}