namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            
            using FileStream fileToRead = new FileStream(inputFilePath, FileMode.Open);
            

            using (FileStream fileToWrite = new FileStream(outputFilePath, FileMode.Create))
            {
                int readCount;
                byte[] buffer = new byte[1024];
                while ((readCount = fileToRead.Read(buffer, 0, buffer.Length)) != 0)
                {                   
                    
                    fileToWrite.Write(buffer, 0, buffer.Length);
                }
                              
            }
           
        }
    }
}
