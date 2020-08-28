using System;
using System.IO;
using System.Collections.Generic;

namespace HW17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = "C:\\folder1";
            var directory = new DirectoryInfo(folder);

            if (!directory.Exists)
            {
                directory.Create();
                directory.CreateSubdirectory(@"sub_filder1");
                directory.CreateSubdirectory(@"sub_filder2");                
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            string folder2 = "C:\\folder2";
            var directory2 = new DirectoryInfo(folder2);
            if (!directory2.Exists)
            {
                directory2.Create();                
                directory.CreateSubdirectory("sub_folder2_1");
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }


            Console.WriteLine("Директории созданы.");

            Console.WriteLine($"Название каталога: {directory.Name}");
            Console.WriteLine($"Полное название каталога: {directory.FullName}");
            Console.WriteLine($"Время создания каталога: {directory.CreationTime}");
            Console.WriteLine($"Корневой каталог: {directory.Root}");



            Console.ReadKey();

        }
    }
}
