using System;
using System.IO;



class Program
{
    static void ShowDirectory(DirectoryInfo dir)
    {
        // Показать все файлы
        foreach (FileInfo file in dir.GetFiles())
        {
            Console.WriteLine($"FILE: {file.FullName}");
        }
        // Показать все директории
        foreach (DirectoryInfo subDir in dir.GetDirectories())
        {
            ShowDirectory(subDir);
        }
    }
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory); ShowDirectory(dir);
    }
}