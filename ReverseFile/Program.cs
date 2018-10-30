using System;
using System.IO;
using System.Reflection;

namespace ReverseFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Input.txt");
            var outputPath = Path.Combine(Environment.CurrentDirectory, @"Data\Output.txt");
            var inputLines = new string[0];

            if (!File.Exists(inputPath))
            {
                throw new FileNotFoundException();
            }

            try
            {
                inputLines = File.ReadAllLines(inputPath);
            }
            catch (Exception ex)
            {
                // log the error with ex
            }

            var output = FileReverse.ReverseLines(inputLines);

            File.WriteAllLines(outputPath, output);
        }
    }
}
