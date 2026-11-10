using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public readonly struct GeoCoordinate
    {
        #region Св-ва только для чтения
        /// <summary>
        /// Широта
        /// </summary>
        public double Latidude { get; }
        /// <summary>
        /// долгота
        /// </summary>
        public double Longitude { get; }
        #endregion

        #region Конструктор
        /// <summary>
        /// принимает latitude и longitude. Добавляет валидацию: широта от -90 до 90, долгота от -180 до 180 (при выходе за границы устанавливать крайнее значение);
        /// </summary>
        /// <param name="latidude">широта</param>
        /// <param name="longitude">долгота</param>
        public GeoCoordinate(double latidude, double longitude)
        {
           Latidude = latidude;
           Longitude = longitude;
            
            if (latidude >= -90 || latidude < 90)
            {
               Latidude = latidude;
            }
            else if (longitude >= -180 || longitude < 90)
            {
                Longitude = longitude;
            }
        }
        #endregion

        #region Метод
        /// <summary>
        /// рассчитывает приближенное декартово расстояние до другой точки по формуле.
        /// </summary>
        /// <param name="other">другой</param>
        /// <returns></returns>
        public double DistanceTo(GeoCoordinate other)
        {
            return Math.Sqrt(Math.Pow(Latidude - other.Latidude, 2) + Math.Pow(Longitude - other.Longitude, 2)) * 111.0;
        }
        #endregion

        #region Переопределенный метод
        /// <summary>
        /// возвращает строку вида $"({Latitude:F4}, {Longitude:F4})"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({Latidude:F4}, {Longitude:F4}).";
        }
        #endregion
    }
}
