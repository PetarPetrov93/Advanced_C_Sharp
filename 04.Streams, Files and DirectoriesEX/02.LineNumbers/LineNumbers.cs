namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {            
            int lettersCounter = 0;
            int punctuationMarksCounter = 0;
            StringBuilder textToWrite = new();
                        
            string[] currentLine = File.ReadAllLines(inputFilePath);
            for (int i = 0; i < currentLine.Length; i++)
            {
                foreach (char symbol in currentLine[i])
                {
                    if (char.IsLetter(symbol))
                    {
                        lettersCounter++;
                    }
                    else if (char.IsPunctuation(symbol))
                    {
                        punctuationMarksCounter++;
                    }
                }
                textToWrite.AppendLine($"Line {i+1}: {string.Join(" ", currentLine[i])} ({lettersCounter})({punctuationMarksCounter})");
                lettersCounter = 0;
                punctuationMarksCounter = 0;
            }
            
            
            
            File.WriteAllText(outputFilePath, textToWrite.ToString());
        }
    }
}
