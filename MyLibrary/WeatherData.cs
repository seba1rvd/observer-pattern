using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class WeatherData : ISubject
    {
        /// <summary>
        /// Список для хранения наблюдателей
        /// </summary>
        readonly List<IObserver> observers = new List<IObserver> { };

        /// <summary>
        /// Оповещение наблюдателей
        /// </summary>
        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update(data);
            }
        }

        /// <summary>
        /// Регистрация нового наблюдателя
        /// </summary>
        /// <param name="item">Регистрируемый наблюдатель</param>
        public void RegisterObserver(IObserver item)
        {
            observers.Add(item);
        }

        /// <summary>
        /// Удаление наблюдателя
        /// </summary>
        /// <param name="item">удаляемый наблюдатель</param>
        public void RemoveObserver(IObserver item)
        {
            observers.Remove(item);
        }

        /// <summary>
        /// Смена измерений
        /// </summary>
        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        readonly Data data = new Data();

        /// <summary>
        /// изменение текущей температуры
        /// </summary>
        public double CurrentTemperature
        {
            get { return data.currentTemp; }
            set
            {
                data.currentTemp = value;
                data.StatisticTemp(data.currentTemp);
                MeasurementsChanged();
            }
        }

        /// <summary>
        /// изменение текущей влажности
        /// </summary>
        public double CurrentHumidity
        {
            get { return data.currentHumidity; }
            set
            {
                data.currentHumidity = value;
                data.StatisticHumidity(data.currentHumidity);
                MeasurementsChanged();
            }
        }

        /// <summary>
        /// изменение текущего давления
        /// </summary>
        public double CurrentPressure
        {
            get { return data.currentPressure; }
            set
            {
                data.currentPressure = value;
                data.StatisticPressure(data.currentPressure);
                MeasurementsChanged();
            }
        }
    }
}