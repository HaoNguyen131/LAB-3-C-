using System;
using System.Diagnostics;
using System.IO;
class Program
{
    static void create()
    {
        string dataDirectory = @"..\\..\\..\data\\";

        Directory.CreateDirectory(dataDirectory);

        string dataFilePath = Path.ChangeExtension(dataDirectory, "data.txt");

        using (StreamWriter writer = new StreamWriter(dataFilePath))
        {
            writer.WriteLine("du lieu duoc ghi vao file data.txt trong thu muc data");
        }
        Console.WriteLine("da ghi xong: " + dataFilePath);

    }
    static void copy()
    {
        string sourceDirectory = @"..\\..\\..\data\\";
        string targetDirectory = @"..\\..\\..\data2\\";

        if (Directory.Exists(sourceDirectory))
        {
            Directory.CreateDirectory(targetDirectory);

            string[] files = Directory.GetFiles(sourceDirectory);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string targetFile = Path.Combine(targetDirectory, fileName);
                File.Copy(file, targetFile, true);
            }
            Console.WriteLine("Sao chep hoan tat.");
        }
        else
        {
            Console.WriteLine("thu muc nguon khong ton tai."); ;
        }
    }
    static void Main()
    {
        create();
        copy();
        
    }
}
