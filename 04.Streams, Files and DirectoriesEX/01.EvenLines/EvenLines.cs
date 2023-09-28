namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            string text = string.Empty;
            StringBuilder sb = new StringBuilder();
            using (StreamReader readText = new StreamReader(inputFilePath))
            {
                int lineCount = 0;

                while (!readText.EndOfStream)
                {
                    text = readText.ReadLine();
                    if (lineCount % 2 == 0)
                    {
                        text = text.Replace('.', '@').Replace(',', '@').Replace('!', '@').Replace('?', '@').Replace('-', '@');
                        string[] textAsArr = text.Split();
                        Array.Reverse(textAsArr);
                        text = string.Join(" ", textAsArr);
                        sb.Append(text + "\n");
                    }

                    lineCount++;
                }

            }
            return sb.ToString();
        }
    }
}
