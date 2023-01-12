using System.IO;

string sourcePath = @"C:\temp\file1.txt";
string targetPath = @"c:\temp\file2.txt";


try
{
    FileInfo file= new FileInfo(sourcePath);
    file.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);//guaradará cada linha no vetor instanciado lines
    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch(IOException e)
{
    Console.WriteLine("Error occurred: " + e.Message);
}