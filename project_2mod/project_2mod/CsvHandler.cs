using System;
using System.Text;
using System.Globalization;
using System.IO;

namespace project_2mod;

public class CsvHandler
{
    public List<PostOffice> LoadFromCsv(string filePath)
    {
        var postOffices = new List<PostOffice>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            bool isFirstLine = true;
            foreach (var line in lines)
            {
                // Пропускаем первую строку с заголовками
                if (isFirstLine)
                {
                    isFirstLine = false;
                    continue;
                }

                var parts = line.Split(',');
                if (parts.Length != 5)
                {
                    Console.WriteLine("Ошибка: Неверный формат строки в файле CSV.");
                    continue;
                }

                try
                {
                    string stateName = parts[0].Trim();
                    string placeName = parts[1].Trim();
                    string postCode = parts[2].Trim();
                    double latitude = double.Parse(parts[3].Trim(), CultureInfo.InvariantCulture);
                    double longitude = double.Parse(parts[4].Trim(), CultureInfo.InvariantCulture);

                    var postOffice = new PostOffice(stateName, placeName, postCode, latitude, longitude);
                    postOffices.Add(postOffice);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Ошибка: Неверный формат данных в строке: {line}");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Ошибка при чтении файла: {e.Message}");
        }

        return postOffices;
    }
}