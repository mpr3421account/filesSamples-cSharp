using System.IO;

string sourcePath = @"C:\temp\myfolder";


try
{
    var folders = Directory.EnumerateDirectories(sourcePath,"*.*", SearchOption.AllDirectories);//listando todas as pastas
    Console.WriteLine("Folders:");
    foreach(string s in folders)
    {
        Console.WriteLine(s);
    }
    var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);//listando todos os arquivos
    Console.WriteLine("Files:");
    foreach (string s in files)
    {
        Console.WriteLine(s);
    }

    Directory.CreateDirectory(sourcePath + @"\newFolder");//criando diretorios
}
catch (IOException e)
{
    Console.WriteLine("An error occcurred: " + e.Message);
}