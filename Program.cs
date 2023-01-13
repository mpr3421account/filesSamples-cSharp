using System.IO;

string sourcePath = @"C:\temp\myfolder";


try
{
    var folders = Directory.EnumerateDirectories(sourcePath,"*.*", SearchOption.AllDirectories);
    Console.WriteLine("Folders:");
    foreach(string s in folders)
    {
        Console.WriteLine(s);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occcurred: " + e.Message);
}