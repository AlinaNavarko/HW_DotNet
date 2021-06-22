using System;
using System.IO;

namespace HW._02.Image
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Create an object for Reading the file from the following path C:\Temp\image.txt
            //2. Create an Array, that will store the info that was read
            //3. Parse the data and Convert all the data one by one
            //4. Create a new file 'image.png' and write the specified Byte array to that file
            //5. Close the file.

            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
           
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}
