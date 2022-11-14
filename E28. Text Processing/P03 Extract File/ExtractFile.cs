using System;

class ExtractFile
{
    static void Main()
    {
        string path = Console.ReadLine();
        string file = path.Substring(path.LastIndexOf('\\') +1, path.Length-path.LastIndexOf('\\')-1);
        string fileName = file.Substring(0, file.IndexOf('.'));
        string fileExtension = file.Substring(file.IndexOf('.')+1, file.Length - file.IndexOf('.')-1);

        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"File extension: { fileExtension}");
    }
}
