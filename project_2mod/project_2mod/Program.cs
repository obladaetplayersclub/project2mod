using System;
using System.Text;
using System.Globalization;
using System.IO;
using project_2mod;

class Program
{
    static void Main(string[] args)
    {
        CsvHandler csvHandler = new CsvHandler();
        Console.WriteLine("Введите путь к файлу CSV: ");
        string filePath = Console.ReadLine();

        List<PostOffice> postOffices = csvHandler.LoadFromCsv(filePath);

        if (postOffices.Count > 0)
        {
            Console.WriteLine($"Успешно загружено {postOffices.Count} записей.");
        }
        else
        {
            Console.WriteLine("Не удалось загрузить данные из файла.");
        }
    }
}