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
            Random randNum = new Random();
            int newRandNum = 0;
            // Get Filename
            Console.Write("Enter Filename: ");
            //string fname = Console.ReadLine();
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

                // Write our file data to the screen.
                string curLine;
                while ((curLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(wordCount);
                    wordsInFile.Add(curLine);
                    //Console.WriteLine(curLine);
                    Console.WriteLine(wordsInFile[wordCount]);
                    wordCount++;

                }

                // Close our reader object.
                reader.Close();
                newRandNum = randNum.Next(0, wordsInFile.Count - 1);
                Console.WriteLine(newRandNum);
                string data = wordsInFile[newRandNum];
                charsInWord.AddRange(data);
                for (int i = 0; i < charsInWord.Count; i++)
                {
                    Console.Write($"{charsInWord[i]},");
                }
            }
            else
            {
                Console.WriteLine($"The filename {fname} does not exist.");
            }

        }
    }
}
