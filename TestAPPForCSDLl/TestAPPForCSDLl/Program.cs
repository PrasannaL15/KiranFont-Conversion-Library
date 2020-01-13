using System;
using System.IO;
using ClassLibrary1;
namespace TestAPPForCSDLl
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.KiranFont obj = new ClassLibrary1.KiranFont();

            
            // Make sure to change this folder to your own folder  
            // Filename  
            Console.WriteLine("Enter input File Path(eg. c:\\Users\\input.txt):");
            String InputfilePath = Console.ReadLine();
            InputfilePath = InputfilePath.Replace(" ", "");

            // Fullpath. You can direct hardcode it if you like.  
            // An array of strings  
            string text = File.ReadAllText(InputfilePath);
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Enter Output File Path(eg. c:\\Users\\output.txt):");
            String OutputfilePath = Console.ReadLine();
            OutputfilePath = OutputfilePath.Replace(" ", "");

            String Result ="";
            // Result = obj.KfPreprocess(text);
            
            for(int i = 0; i < text.Length;i++)
            {
                Result += obj.KFKiran2Uni(text[i]);
            }
            // Write array of strings to a file using WriteAllLines.  
            // If the file does not exists, it will create a new file.  
            // This method automatically opens the file, writes to it, and closes file  
            File.WriteAllText(OutputfilePath, Result);
            // Read a file  
            
      
        }
    }
}
