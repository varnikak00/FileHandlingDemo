using System;
using System.IO;

namespace FileIOOperationDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //FileExits();
                //ReadAllFiles();
                //ReadAllText();
                //DeleteFile();
                //CopyFile();

                StreamReaderDemo streamReaderDemo = new StreamReaderDemo();
                //streamReaderDemo.ReadFromStreamReader();

                //streamReaderDemo.WriteUsingStreamWriter();


                BinarySerialization binarySerialization = new BinarySerialization();

                //binarySerialization.Serialization();
                binarySerialization.DeSerialization();
            }

            public static void FileExits()
            {
                string Path = @"C:\Users\gokul\source\repos\FileIOOperation/Example1.txt";
                if (File.Exists(Path))
                {
                    Console.WriteLine("File Exists");
                }
                else
                {
                    Console.WriteLine("File Not Exists");
                }
                Console.WriteLine("--------------");
            }

            public static void ReadAllFiles()
            {
                string Path = @"C:\Users\gokul\source\repos\FileIOOperation/Example1.txt";
                String[] lines;
                lines = File.ReadAllLines(Path);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
                Console.WriteLine("--------------");
            }

            public static void ReadAllText()
            {
                string Path = @"C:\Users\gokul\source\repos\FileIOOperation/Example1.txt";
                String lines;
                lines = File.ReadAllText(Path);
                Console.WriteLine(lines);
                Console.WriteLine("--------------");
            }

            public static void DeleteFile()
            {
                string Path = @"C:\Users\gokul\source\repos\FileIOOperation/Example2.txt";

                File.Delete(Path);
                Console.WriteLine("--------------");
            }

            public static void CopyFile()
            {
                string Path = @"C:\Users\gokul\source\repos\FileIOOperation/Example1.txt";
                string CopyPath = @"C:\Users\gokul\source\repos\FileIOOperation/Exaple1.txt";

                File.Copy(Path, CopyPath);
                Console.WriteLine("--------------");
            }


        }
    }

   