using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        double temperature;
        double humidity;
        double pressure;
        readonly Random rnd = new Random();

        public string Display()
        {
            return "Прогноз погоды:\n" + "Температура: " + temperature + "\nВлажность: " + humidity + "\nДавление: " + pressure;
        }

        /// <summary>
        /// Получение новых показателей текущей температуры
        /// </summary>
        /// <param name="data">Данные</param>
        public void Update(Data data)
        {
            temperature = data.currentTemp * (rnd.Next(5, 15) / 10.0);
            humidity = data.currentHumidity * (rnd.Next(5, 15) / 10.0);
            pressure = data.currentPressure * (rnd.Next(9, 11) / 10.0);
        }
    }
}