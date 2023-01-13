using System.IO;

string sourcePath = @"C:\temp\file1.txt";

using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
{
    using (StreamReader sr = new StreamReader(fs))
    {
        while(!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}