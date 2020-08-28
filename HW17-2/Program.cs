using System;
using System.IO;
using System.Threading.Tasks;


namespace HW17_2
{
    class Program
    {
       

        static async Task Main(string[] args)
        {
            Title();

            string target = Path();

            var creatFile = File.CreateText(target);
            creatFile.Close();
            
            using (var targetStream = new StreamWriter(target, true))
            {
                string line;
                do
                {
                    OutConsole("Введите слово для записи в текст\n>");
                    line = Console.ReadLine();

                    await targetStream.WriteLineAsync(line);
                }
                while (line != string.Empty);
                targetStream.Close();
            }
            
            Title();

            OutConsole("Нажмите лубую клавишу для читение из текста\n>");
            
            Console.ReadKey();

            using (var reader = File.OpenText(target))
            {
                Title();
                Console.Write(reader.ReadToEnd());
            }

            Console.Read();

            static void Title() => Console.WriteLine(new string('-', 31));
            
            static string Path() 
            {
                Console.Write("Введите путь к файлу target.txt\n>");
                string input;
                input = Console.ReadLine();
                return @$"{input}\target.txt";
            }
            
            static void OutConsole(string text)
            {
                Console.Write(text);
            } 
        }


    }
}
