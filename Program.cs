using System;
using ClasClassLibrary1s1;

namespace Lab05App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть мiст: ");
            int cntTowns = int.Parse(Console.ReadLine());
            Town[] arrTowns = new Town[cntTowns];

            for (int i = 0; i < cntTowns; i++)
            {
                Console.WriteLine($"\n--- Місто №{i + 1} ---");
                Console.Write("Введiть назву мiста: ");
                string sName = Console.ReadLine();
                Console.Write("Введiть назву краiни: ");
                string sCountry = Console.ReadLine();
                Console.Write("Введiть назву регiону: ");
                string sRegion = Console.ReadLine();
                Console.Write("Введiть кiлькiсть населення: ");
                int population = int.Parse(Console.ReadLine());
                Console.Write("Введiть рiчний дохiд: ");
                double yearIncome = double.Parse(Console.ReadLine());
                Console.Write("Введiть площу, кв. км: ");
                double square = double.Parse(Console.ReadLine());
                Console.Write("Чи є у мiстi порт? (y - так, n - нi): ");
                bool hasPort = Console.ReadKey().Key == ConsoleKey.Y;
                Console.WriteLine();
                Console.Write("Чи є у мiстi аеропорт? (y - так, n - нi): ");
                bool hasAirport = Console.ReadKey().Key == ConsoleKey.Y;
                Console.WriteLine();

                arrTowns[i] = new Town
                {
                    Name = sName,
                    Country = sCountry,
                    Region = sRegion,
                    Population = population,
                    YearIncome = yearIncome,
                    Square = square,
                    HasPort = hasPort,
                    HasAirport = hasAirport
                };
            }
            Console.WriteLine("\n--- ІНФОРМАЦІЯ ПРО МІСТА ---");
            foreach (Town t in arrTowns)
            {
                Console.WriteLine($"\nМісто: {t.Name}");
                Console.WriteLine($"Країна: {t.Country}");
                Console.WriteLine($"Регіон: {t.Region}");
                Console.WriteLine($"Населення: {t.Population}");
                Console.WriteLine($"Річний дохід: {t.YearIncome:0.00}");
                Console.WriteLine($"Площа: {t.Square:0.000} кв.км");
                Console.WriteLine(t.HasPort ? "У місті є порт" : "У місті нема порту");
                Console.WriteLine(t.HasAirport ? "У місті є аеропорт" : "У місті нема аеропорту");
                Console.WriteLine($"Середній дохід на мешканця: {t.YearIncomePerInhabitant:0.00}");
                Console.WriteLine($"Густота населення: {t.PopulationDensity:0.00} осіб/км²");
            }

            Console.ReadKey();
        }
    }
}
