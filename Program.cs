using System.IO;

string sourcePath = @"C:\temp\file1.txt";

FileStream fs = null;
StreamReader sr = null;
try
{
    fs = new FileStream(sourcePath, FileMode.Open);
    sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch(IOException e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}
finally
{
    if(sr != null) sr.Close();
    if(fs != null) fs.Close();
}
