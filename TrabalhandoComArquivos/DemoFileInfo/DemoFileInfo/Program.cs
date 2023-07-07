using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\Users\cbyk-dev\source\repos\curso\TrabalhandoComArquicos\";
            string sourcePath = caminho + "file1.txt";
            string targetPath = caminho + "file2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}