using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();

            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay();
            ForecastDisplay fd = new ForecastDisplay();
            StatisticsDisplay sd = new StatisticsDisplay();

            ///Регистрация наблюдателей
            wd.RegisterObserver(ccd);
            wd.RegisterObserver(fd);
            wd.RegisterObserver(sd);

            ///Случайное заполнение текущих температуры, давления, влажности
            Random rnd = new Random();
            for (int i = 0; i < 24; i++)
            {
                wd.CurrentHumidity = rnd.Next(40, 60);
                wd.CurrentPressure = rnd.Next(740, 755);
                wd.CurrentTemperature = rnd.Next(100, 250) / 10.0;
            }

            Console.WriteLine(ccd.Display());
            Console.WriteLine();
            Console.WriteLine(fd.Display());
            Console.WriteLine();
            Console.WriteLine(sd.Display());

            Console.ReadKey();
        }
    }
}