// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.IO;
using System;

namespace pr1_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = File.CreateText(@"C:\!Полина\newfile.txt");
            writer.WriteLine("This is my new ezhik");
            writer.WriteLine("Do you like its ezhik?");
            writer.Close();

            StreamReader reader = File.OpenText(@"C:\!Полина\newfile.txt");
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);

        }
    }
} 