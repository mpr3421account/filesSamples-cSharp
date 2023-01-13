using System.IO;

string sourcePath = @"C:\temp\file1.txt";

try
{
    //using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
    //{
    using (StreamReader sr = File.OpenText(sourcePath)) 
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    //}
}
catch(IOException e)
{
    Console.WriteLine("An error occcurred: " + e.Message);
}