using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1_files_lists_TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            testMethod();
        }
        static void testMethod()
        {
            Random randNum = new Random();
            int newRandNum = 0;
            string fname = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
            List<string> wordsInFile = new List<string>();
            List<char> charsInWord = new List<char>();
            int wordCount = 0;

            // check if File exists
            if (File.Exists(fname))
            {
                Console.WriteLine("CurrentDirectory: " + Environment.CurrentDirectory);
                Console.WriteLine("SystemDirectory: " + Environment.SystemDirectory);
                Console.WriteLine("TempDirectory: " + Environment.GetEnvironmentVariable("TEMP"));
                StreamReader reader = new StreamReader(fname);
                string curLine;
                while ((curLine = reader.ReadLine()) != null)
                { 
                    wordsInFile.Add(curLine);
                }
                reader.Close();
                for(int i = 0; i < wordsInFile.Count; i++)
                {
                    Console.WriteLine($"word index: {i}, word: {wordsInFile[i]}");
                }
                newRandNum = randNum.Next(0, wordsInFile.Count - 1);
                Console.WriteLine($"Random word index: {newRandNum}");
                string data = wordsInFile[newRandNum];
                charsInWord.AddRange(data);
                for (int i = 0; i < charsInWord.Count; i++)
                {
                    Console.WriteLine($"char index: {i}, char: {charsInWord[i]}");
                }
            }
            else
            {
                Console.WriteLine($"The filename {fname} does not exist.");
            }

        }
    }
}
