using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        double minTemp;
        double maxTemp;
        double averageTemp;

        double minHumidity;
        double maxHumidity;
        double averageHumidity;

        double minPressure;
        double maxPressure;
        double averagePressure;

        public string Display()
        {
            return "Статистика:" + "\nМинимальная температура: " + minTemp +
                   "\nМаксимальная температура: " + maxTemp +
                   "\nСредняя температура: " + averageTemp +

                   "\n\nМинимальная влажность: " + minHumidity +
                   "\nМаксимальная влажность: " + maxHumidity +
                   "\nСредняя влажность: " + averageHumidity +

                   "\n\nМинимальное давление: " + minPressure +
                   "\nМаксимальное давление: " + maxPressure +
                   "\nСреднее давление: " + averagePressure;
        }

        /// <summary>
        /// Получение статистики
        /// </summary>
        /// <param name="data">Данные статистики</param>
        public void Update(Data data)
        {
            minTemp = data.minTemp;
            maxTemp = data.maxTemp;
            averageTemp = data.averageTemp;

            minHumidity = data.minHumidity;
            maxHumidity = data.maxHumidity;
            averageHumidity = data.averageHumidity;

            minPressure = data.minPressure;
            maxPressure = data.maxPressure;
            averagePressure = data.averagePressure;
        }
    }
}