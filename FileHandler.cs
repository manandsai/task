using System;
using System.Collections.Generic;
using System.IO;

namespace task
{
    public class FileHandler
    {
        public void WritingFile(List<Person> person)
        {
            string path = @"C:\Users\manandsai\text.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
            using (var writeToFile = new StreamWriter(path, true))
            {
                foreach (var item in person)
                {
                    string messageToBePrinted = string.Concat("FirstName: ", item.FirstName, Environment.NewLine, "LastName: ", item.LastName, Environment.NewLine,  "PhoneNumber: ", item.PhoneNumber, Environment.NewLine, "Email: ", item.Email);
                    writeToFile.WriteLine(messageToBePrinted);
                     writeToFile.WriteLine("*************");
                }
            }
        }
        public void ReadFromFile(){
          string[] fileLines = System.IO.File.ReadAllLines(@"C:\Users\manandsai\text.txt");
           
      //  foreach (string line in fileLines)
       // {
            
       //     Console.WriteLine("\t" + line);
           
      //  }
         string text = System.IO.File.ReadAllText(@"C:\Users\manandsai\text.txt");
         System.Console.WriteLine("Contents of file are = {0}", text);


          }
    }
}
