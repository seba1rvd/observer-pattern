using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Data
    {
        public double currentTemp;
        public double currentHumidity;
        public double currentPressure;

        public double minTemp = double.NaN;
        public double maxTemp = double.NaN;
        public double averageTemp;

        public double minHumidity = double.NaN;
        public double maxHumidity = double.NaN;
        public double averageHumidity;

        public double minPressure = double.NaN;
        public double maxPressure = double.NaN;
        public double averagePressure;


        /// <summary>
        /// Обновление статистики температуры
        /// </summary>
        /// <param name="newTemp">Новая температура</param>
        public void StatisticTemp(double newTemp)
        {
            if (double.IsNaN(minTemp))
            {
                minTemp = newTemp;
            }

            else if (minTemp > newTemp)
            {
                minTemp = newTemp;
            }

            if (double.IsNaN(maxTemp))
            {
                maxTemp = newTemp;
            }
            else if (maxTemp < newTemp)
            {
                maxTemp = newTemp;
            }

            averageTemp = (minTemp + maxTemp) / 2;
        }

        /// <summary>
        /// Обновление статистики давления
        /// </summary>
        /// <param name="newPressure">Новое давление</param>
        public void StatisticPressure(double newPressure)
        {
            if (double.IsNaN(minPressure))
            {
                minPressure = newPressure;
            }

            else if (newPressure < minPressure)
            {
                minPressure = newPressure;
            }

            if (double.IsNaN(maxPressure))
            {
                maxPressure = newPressure;
            }

            else if (newPressure > maxPressure)
            {
                maxPressure = newPressure;
            }

            averagePressure = ((minPressure + maxPressure) / 2);

        }

        /// <summary>
        /// Обновление статистики влажности
        /// </summary>
        /// <param name="newHumidity"></param>
        public void StatisticHumidity(double newHumidity)
        {
            if (double.IsNaN(minHumidity))
            {
                minHumidity = newHumidity;
            }
            else if (newHumidity < minHumidity)
            {
                minHumidity = newHumidity;
            }

            if (double.IsNaN(maxHumidity))
            {
                maxHumidity = newHumidity;
            }
            else if (newHumidity > maxHumidity)
            {
                maxHumidity = newHumidity;
            }

            averageHumidity = (minHumidity + maxHumidity) / 2;
        }
    }
}